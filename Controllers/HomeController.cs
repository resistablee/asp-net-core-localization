using Localization.Languages;
using Localization.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace Localization.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHtmlLocalizer<Lang> _localizer;

        public HomeController(IHtmlLocalizer<Lang> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var asd = _localizer["Greeting"];
            ViewData["Greeting"] = _localizer["Greeting"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}