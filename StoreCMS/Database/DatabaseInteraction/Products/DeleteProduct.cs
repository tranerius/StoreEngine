﻿using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Treynessen.Extensions;
using Treynessen.Database.Context;
using Treynessen.Database.Entities;

namespace Treynessen.Database
{
    public static partial class DatabaseInteraction
    {
        public static void DeleteProduct(CMSDatabase db, int? productID, HttpContext context, out int? categoryID)
        {
            if (!productID.HasValue)
            {
                categoryID = null;
                return;
            }
            ProductPage deletedProduct = db.ProductPages.FirstOrDefaultAsync(pp => pp.ID == productID.Value).Result;
            categoryID = deletedProduct.PreviousPageID;
            IHostingEnvironment env = context.RequestServices.GetRequiredService<IHostingEnvironment>();
            string pathToImages = $"{env.GetProductsImagesFolderFullPath()}{deletedProduct.PreviousPageID}{deletedProduct.ID}\\";
            if (Directory.Exists(pathToImages))
                Directory.Delete(pathToImages, true);
            CategoryPage categoryPage = db.CategoryPages.FirstOrDefaultAsync(cp => cp.ID == deletedProduct.PreviousPageID).Result;
            --categoryPage.ProductsCount;
            db.ProductPages.Remove(deletedProduct);
            db.SaveChanges();
        }
    }
}