﻿using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Treynessen.Functions;
using Treynessen.Extensions;
using Treynessen.Localization;
using Treynessen.LogManagement;
using Treynessen.Database.Context;
using Treynessen.Database.Entities;
using Treynessen.TemplatesManagement;

namespace Treynessen.Database
{
    public static partial class DatabaseInteraction
    {
        public static void DeleteChunk(CMSDatabase db, int? itemID, HttpContext context, out bool successfullyDeleted)
        {
            if (!itemID.HasValue)
            {
                successfullyDeleted = false;
                return;
            }
            Chunk chunk = db.Chunks.FirstOrDefault(t => t.ID == itemID);
            if (chunk == null)
            {
                successfullyDeleted = false;
                return;
            }
            IHostingEnvironment env = context.RequestServices.GetRequiredService<IHostingEnvironment>();
            string pathToChunkFile = $"{env.GetChunksFolderFullPath()}{chunk.Name}.cshtml";
            if (File.Exists(pathToChunkFile))
                File.Delete(pathToChunkFile);
            db.Chunks.Remove(chunk);
            db.SaveChanges();
            successfullyDeleted = true;
            LogManagementFunctions.AddAdminPanelLog(
                db: db,
                context: context,
                info: $"{chunk.Name} (ID-{chunk.ID.ToString()}): {(context.Items["LogLocalization"] as IAdminPanelLogLocalization)?.ChunkDeleted}"
            );

            // Получаем список чанков и шаблонов, использующих данный чанк и делаем перерендер
            var templates = db.Templates.AsNoTracking().Where(t => t.TemplateSource.Contains($"[#{chunk.Name}]")).ToList();
            var chunks = db.Chunks.AsNoTracking().Where(tc => tc.TemplateSource.Contains($"[#{chunk.Name}]")).ToList();
            var renderTask = Task.Run(() =>
            {
                foreach (var t in templates)
                {
                    string _cshtmlContent = TemplatesManagementFunctions.SourceToCSHTML(
                        db: db,
                        source: t.TemplateSource,
                        modelType: "Page",
                        env: env,
                        skipChunkName: null
                    );
                    TemplatesManagementFunctions.WriteCshtmlContentToFile(env.GetTemplatesFolderFullPath(), t.Name, _cshtmlContent);
                }
            });
            foreach (var c in chunks)
            {
                string _cshtmlContent = TemplatesManagementFunctions.SourceToCSHTML(
                    db: db,
                    source: c.TemplateSource,
                    modelType: "Page",
                    env: env,
                    skipChunkName: c.Name
                );
                TemplatesManagementFunctions.WriteCshtmlContentToFile(env.GetChunksFolderFullPath(), c.Name, _cshtmlContent);
            }

            string productBlockFileContent = OtherFunctions.GetFileContent(env.GetProductBlockTemplateFullPath());
            if (productBlockFileContent.Contains($"[#{chunk.Name}]"))
            {
                string[] additions = {
                        "@using Treynessen.Functions;",
                        "@using Treynessen.Database.Entities;",
                        "@addTagHelper Treynessen.TagHelpers.ImageTagHelper, StoreCMS"
                };
                string productBlockCshtmlTemplate = TemplatesManagementFunctions.SourceToCSHTML(
                    db: db,
                    source: productBlockFileContent,
                    modelType: "ProductPage",
                    env: env,
                    skipChunkName: null,
                    additions: additions
                );
                using (StreamWriter writer = new StreamWriter(env.GetProductBlockCshtmlFullPath()))
                {
                    writer.Write(productBlockCshtmlTemplate);
                }
            }

            renderTask.Wait();
        }
    }
}