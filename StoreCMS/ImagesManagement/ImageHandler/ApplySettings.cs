﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.PixelFormats;
using Treynessen.Functions;
using Treynessen.Extensions;

namespace Treynessen.ImagesManagement
{
    public partial class ImageHandler
    {
        public string CreatedImageFullPath { get; private set; }
        public string CreatedImageSrc { get; private set; }

        public void ApplySettings()
        {
            if (!isExisted)
                return;
            string createdImageFullName = sourceImageName;
            if (widthSetting.HasValue && heightSetting.HasValue)
                createdImageFullName += $"_{widthSetting.Value}x{heightSetting.Value}";
            if (qualitySetting.HasValue)
                createdImageFullName += $"_q{qualitySetting.Value}";
            createdImageFullName += sourceImageExtension;
            CreatedImageFullPath = pathToImageFolder + createdImageFullName;
            if (!File.Exists(CreatedImageFullPath))
            {
                using (Image<Rgba32> sourceImage = Image.Load(sourceImageFullPath))
                {
                    if (widthSetting.HasValue && heightSetting.HasValue)
                        sourceImage.Mutate(x => x.Resize(widthSetting.Value, heightSetting.Value));
                    if (qualitySetting.HasValue)
                    {
                        IImageEncoder imageEncoder = null;
                        switch (sourceImageExtension.ToLower())
                        {
                            case ".jpg":
                            case ".jpeg":
                                var jpegEncoder = new JpegEncoder();
                                jpegEncoder.Quality = qualitySetting.Value;
                                imageEncoder = jpegEncoder;
                                break;
                                // Настройки сжатия для png
                        }
                        sourceImage.Save(CreatedImageFullPath, imageEncoder);
                    }
                    else sourceImage.Save(CreatedImageFullPath);
                }
            }
            CreatedImageSrc = CreatedImageFullPath.Substring(env.GetStorageFolderFullPath().Length - 1);
            if (addImageInfoToDB)
            {
                Database.Entities.Image image = new Database.Entities.Image
                {
                    ShortPath = sourceImageShortPath,
                    ShortPathHash = OtherFunctions.GetHashFromString(sourceImageShortPath),
                    FullName = sourceImageShortPath.Substring(sourceImageShortPath.LastIndexOf('/') + 1),
                    Height = (uint)sourceImageHeight.Value,
                    Width = (uint)sourceImageWidth.Value
                };
                db.Images.Add(image);
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException) { }
            }
        }
    }
}