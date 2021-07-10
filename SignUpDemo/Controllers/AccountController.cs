using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignUpDemo.Models;

namespace SignUpDemo.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(UserModel userModel)
        {
            if (!ModelState.IsValid)
            {

            }
            userModel = userModel.Terms == null ? new UserModel() { Terms = "True" } : userModel;
            return View();
        }
        public IActionResult Message()
        {

            return View();
        }
    }
}
