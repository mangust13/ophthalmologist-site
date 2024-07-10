using Microsoft.AspNetCore.Mvc;

namespace Oculist.Controllers
{
    public class AboutController : Controller
    {
        [Route("about")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("diagnostic-cabinet")]
        public IActionResult DiagnosticCabinet()
        {
            return View();
        }

        [Route("ortoptych-cabinet")]
        public IActionResult OrtoptychCabinet()
        {
            return View();
        }

        
    }
}
