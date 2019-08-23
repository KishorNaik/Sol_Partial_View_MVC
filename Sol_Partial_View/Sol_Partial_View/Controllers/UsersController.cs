using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Partial_View.ViewModel;

namespace Sol_Partial_View.Controllers
{
    public class UsersController : Controller
    {

        [BindProperty]
        public UserViewModel UserView { get; set; }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnSubmit()
        {
            //return View("Index");
            return RedirectToAction("Index");
        }
    }
}