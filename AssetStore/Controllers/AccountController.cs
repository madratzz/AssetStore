using System.Web.Mvc;

namespace AssetStore.Controllers
{
    public class AccountController : Controller
    {
        // GET
        public ActionResult Login()
        {
            return View();
        }
    }
}