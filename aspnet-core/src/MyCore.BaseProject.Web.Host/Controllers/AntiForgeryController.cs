using Microsoft.AspNetCore.Antiforgery;
using MyCore.BaseProject.Controllers;

namespace MyCore.BaseProject.Web.Host.Controllers
{
    public class AntiForgeryController : BaseProjectControllerBase
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
