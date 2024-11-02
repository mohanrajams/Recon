using Microsoft.AspNetCore.Mvc;

namespace Recon.UI.Controllers
{
    public class MasterController: Controller
    {
        public IActionResult Providers()
        {
            return View();
        }
    }
}
