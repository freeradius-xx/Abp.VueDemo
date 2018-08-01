using Microsoft.AspNetCore.Antiforgery;
using Abp.VueDemo.Controllers;

namespace Abp.VueDemo.Web.Host.Controllers
{
    public class AntiForgeryController : VueDemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
