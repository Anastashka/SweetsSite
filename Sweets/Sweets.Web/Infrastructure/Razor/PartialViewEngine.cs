using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sweets.Web.Infrastructure.Razor
{
    public class PartialViewEngine : RazorViewEngine
    {
        private static readonly string[] NewPartialViewFormats =
        {
           "~/Views/{1}/Partials/{0}.cshtml",
           "~/Views/Shared/Partials/{0}.cshtml"
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialViewEngine"/> class.
        /// </summary>
        public PartialViewEngine()
        {
            this.PartialViewLocationFormats = this.PartialViewLocationFormats.Union(NewPartialViewFormats).ToArray();
        }
    }
}