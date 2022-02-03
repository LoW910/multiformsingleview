using Microsoft.AspNetCore.Mvc;

namespace MultiFormSingleView.Controllers
{
    public class IndexViewModelController : Controller
    {
        [HttpGet("indexview")]
        public IActionResult Index() {
            return View();
        }
    }
}