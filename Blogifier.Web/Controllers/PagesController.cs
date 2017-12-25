using Blogifier.Core.Common;
using Microsoft.AspNetCore.Mvc;

namespace Blogifier.Controllers
{
    public class PagesController : Controller
    {
        private readonly string _theme;

        public PagesController()
        {
            _theme = $"~/{ApplicationSettings.BlogThemesFolder}/{BlogSettings.Theme}/";

        }

        public IActionResult About()
        {
            return View(_theme + "Pages/About.cshtml");
        }

        public IActionResult LegalNotice()
        {
            return View(_theme + "Pages/LegalNotice.cshtml");
        }
    }
}