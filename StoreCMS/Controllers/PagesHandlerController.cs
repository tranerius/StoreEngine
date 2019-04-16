﻿using Microsoft.AspNetCore.Mvc;
using Treynessen.Database.Context;

namespace Treynessen.Controllers
{
    public partial class PagesHandlerController : Controller
    {
        private CMSDatabase db;

        public PagesHandlerController(CMSDatabase db)
        {
            this.db = db;
        }
    }
}