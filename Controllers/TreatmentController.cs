using Microsoft.AspNetCore.Mvc;

namespace Oculist.Controllers
{
    public class TreatmentController : Controller
    {
        [Route("treatment")]
        public IActionResult Treatment()
        {
            return View();
        }

        [Route("terapevtic-treatment")]
        public IActionResult Terapevtic()
        {
            return View();
        }

        [Route("orthopedic-treatment")]
        public IActionResult Orthopedic()
        {
            return View();
        }

        [Route("fizioterapevt-cabinet")]
        public IActionResult Fizioterapevt()
        {
            return View();
        }
    }
}
