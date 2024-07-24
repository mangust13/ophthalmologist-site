using Microsoft.AspNetCore.Mvc;

namespace Oculist.Controllers
{
    [Route("contacts")]
    public class ContactsController : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
