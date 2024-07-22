using Microsoft.AspNetCore.Mvc;

namespace Oculist.Controllers
{
    public class NavigationController : Controller
    {
        [Route("computer-diagnostic")]
        public IActionResult Diagnostic()
        {
            return View();
        }

		[Route("children-ophthalmology")]
		public IActionResult Ophthalmology()
        {
            return View();
        }

        [Route("centre-equipment")]
        public IActionResult Equipment()
        {
            return View();
        }

        [Route("frames-and-lenses")]
        public IActionResult FramesAndLenses()
        {
            return View();
        }

        [Route("contact-lenses")]
        public IActionResult ContactLenses()
        {
            return View();
        }
    }
}
