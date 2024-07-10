using Microsoft.AspNetCore.Mvc;

namespace Oculist.Controllers
{
    public class LensesController : Controller
    {
        [Route("lenses")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
