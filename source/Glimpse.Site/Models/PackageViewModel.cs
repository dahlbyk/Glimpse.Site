﻿using Glimpse.Infrastructure;

namespace Glimpse.Site.Models
{
    public class PackageViewModel
    {
        public string Name { get; set; }

        public GlimpsePackageStatus Status { get; set; }

        public string StatusClass
        {
            get
            {
                return Status == GlimpsePackageStatus.Red ? "glyphicon-remove-sign" : "glyphicon-ok-sign";
            }
        }

        public string StatusColour
        {
            get
            {
                return Status == GlimpsePackageStatus.Red ? "red" : "green";
            }
        }

        public string StatusDescription { get; set; }
    }
}