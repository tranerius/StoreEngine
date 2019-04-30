﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Treynessen.Extensions;
using Treynessen.Database.Context;
using Treynessen.Database.Entities;

namespace Treynessen.Functions
{
    public static partial class OtherFunctions
    {
        public static void DeleteProductImage(CMSDatabase db, int? productID, int? imageID, HttpContext context)
        {
            if (!productID.HasValue || !imageID.HasValue)
                return;
            ProductPage product = db.ProductPages.FirstOrDefaultAsync(p => p.ID == productID.Value).Result;
            if (product == null)
                return;
            db.Entry(product).State = EntityState.Detached;
            IHostingEnvironment env = context.RequestServices.GetService<IHostingEnvironment>();
            string imagesPath = $"{env.GetProductsImagesPath()}{product.PreviousPageID}{product.ID}\\";
            string[] images = null;
            try
            {
                images = Directory.GetFiles(imagesPath, $"*{product.Alias}*.jpg");
            }
            catch (DirectoryNotFoundException)
            {
                return;
            }
            if (images == null || images.Length == 0 || images.Length <= imageID)
                return;
            Regex regex = new Regex($"{product.Alias}(_\\d+)?.jpg$");
            images = (from img in images
                      where regex.IsMatch(img)
                      let imageNameEnding = regex.Match(img).Value.Substring(product.Alias.Length)
                      orderby imageNameEnding.Length == 4 ? 0 : Convert.ToInt32(imageNameEnding.Substring(1, imageNameEnding.IndexOf('.') - 1))
                      select img).Skip(imageID.Value).ToArray();
            // Список изменений, которые необходимо внести в файл images.info
            // В key хранится старое имя изображение, в value новое, на которое необходимо заменить
            LinkedList<KeyValuePair<string, string>> listOfChanges = new LinkedList<KeyValuePair<string, string>>();
            string imagesInfoPath = $"{imagesPath}images.info";
            for (int i = 0; i < images.Length; ++i)
            {
                if (i == 0)
                {
                    int beginIndex = images[i].LastIndexOf('\\') + 1;
                    int endIndex = images[i].LastIndexOf('.');
                    string originalImageName = images[i].Substring(beginIndex, endIndex - beginIndex);
                    string[] dependentImages = Directory.GetFiles(imagesPath, $"*{originalImageName}*.jpg");
                    Regex dependentImagesChecker = new Regex($"{originalImageName}(_\\d+x\\d+)?(_q\\d{{1,3}})?.jpg");
                    dependentImages = (from img in dependentImages
                                       where dependentImagesChecker.IsMatch(img)
                                       select img).ToArray();
                    foreach (var di in dependentImages)
                    {
                        File.Delete(di);
                    }
                    Regex imageInfoStringPattern = new Regex($"name = {originalImageName}.jpg; width = \\d+; height = \\d+\n");
                    using (StreamReader reader = new StreamReader(imagesInfoPath))
                    {
                        var forReplace = imageInfoStringPattern.Matches(reader.ReadToEnd());
                        foreach (var fr in forReplace as IEnumerable<Match>)
                        {
                            listOfChanges.AddLast(new KeyValuePair<string, string>(fr.Value, string.Empty));
                        }
                    }
                }
                else RenameImage(imagesPath,
                    $"{product.Alias}_{i + imageID}", $"{product.Alias}{(i + imageID - 1 == 0 ? string.Empty : $"_{i + imageID - 1}")}",
                    listOfChanges);
            }
            StringBuilder builder = null;
            using (StreamReader reader = new StreamReader(imagesInfoPath))
            {
                builder = new StringBuilder(reader.ReadToEnd());
            }
            using (StreamWriter writer = new StreamWriter(imagesInfoPath))
            {
                foreach (var c in listOfChanges)
                {
                    builder.Replace(c.Key, c.Value);
                }
                writer.Write(builder.ToString());
            }
        }
    }
}
