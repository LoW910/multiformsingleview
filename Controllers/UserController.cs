using Microsoft.AspNetCore.Mvc;
using MultiFormSingleView.Models;

namespace MultiFormSingleView.Controllers
{
    public class UserController : Controller
    {
        [HttpPost("create/user")]
        public IActionResult CreateUser(User newUser){
            if(ModelState.IsValid) {
                return RedirectToAction("success","home");
            }
            return View("../IndexViewModel/Index");
        } 
    }
}