using Microsoft.AspNetCore.Mvc;
using MultiFormSingleView.Models;

namespace MultiFormSingleView.Controllers
{
    public class ProductController : Controller{

        [HttpPost("create/product")]
        public IActionResult CreateProduct(Product newProduct) {
            if (ModelState.IsValid) {
                return RedirectToAction("success", "home");
            } 
            return View("../IndexViewModel/Index");
        }

    }
}