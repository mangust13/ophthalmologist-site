using Microsoft.AspNetCore.Mvc;

namespace Oculist.Controllers
{
    [Route("questions")]
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
