using MCISBCWebApp.Services;
using System.Web.Mvc;

namespace MCISBCWebApp.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ComplaintService complaintEntityService;
        private readonly AuthService authService;
        public HomeController()
        {
            complaintEntityService = new ComplaintService();
            authService = new AuthService();
        }

        [AllowAnonymous]
        public System.Web.Mvc.ActionResult Index()
        {

            return View();
            //return new HttpStatusCodeResult(401, "Unauthorized");

        }

    }
}