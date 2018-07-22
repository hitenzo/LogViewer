using Microsoft.AspNetCore.Antiforgery;
using LogViewer.Controllers;

namespace LogViewer.Web.Host.Controllers
{
    public class AntiForgeryController : LogViewerControllerBase
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
