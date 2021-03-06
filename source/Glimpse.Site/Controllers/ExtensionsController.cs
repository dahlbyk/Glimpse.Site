﻿using System.Linq;
using System.Web.Mvc;
using Glimpse.Package;

namespace Glimpse.Site.Controllers
{
    public partial class ExtensionsController : Controller
    {
        public virtual ActionResult Index()
        {
            var packages = PackageSettings.Settings.QueryProvider.SelectAllPackages();
            var result = packages.Select(keyValue => keyValue.Value.FirstOrDefault(value => value.IsAbsoluteLatestVersion)).Where(x => x != null).OrderBy(x => x.Name).OrderByDescending(x => x.DownloadCount).ToList();

            return View(result);
        }
	}
}