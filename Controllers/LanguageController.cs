using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Localization.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("change-language")]
        public IActionResult ChangeLanguage(string language)
        {
            //Response.Cookies.Append("Language", language);
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(language)));
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}