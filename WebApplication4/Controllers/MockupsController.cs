using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reset()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Reset(string action)
        {
            if (action == "Verify")
            {
                ViewBag.n = 0;
                return View();
            }
            else
            {
                string str = Request.Form["email"];
                ViewBag.mess = str;
                return View();
            }
        }
            public IActionResult SignUp()
        {
            ViewBag.n = 0;
            return View(new Registration());
        }
        [HttpPost]
        public IActionResult SignUp(Registration model, int count)
        {
            if(count == 0)
            {
                string day = Request.Form["day"];
                string month = Request.Form["month"];
                string year = Request.Form["year"];
                model.Birthday = day + " " + month + " " + year;
                ViewBag.n = 1;
                return View(model);
            }
            else if (count == 1)
            {
                string pass = Request.Form["password1"];
                string word = Request.Form["password2"];
                if (pass == word)
                {
                    model.Password = pass;
                    return View("SignUpCredentials", model);
                }
                else
                {
                    ViewBag.mess = "*Пароли не совпадают";
                    ViewBag.n = 1;
                    return View(model);
                }
            }
            return View();
        }
    }
}
