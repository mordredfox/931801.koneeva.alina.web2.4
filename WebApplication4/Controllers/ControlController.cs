using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class ControlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TextBox()
        {
            if (Request.Method == "POST")
            {
                string str = Request.Form["text"];
                ViewBag.mess = str;
                return View();
            }
            return View();
        }
        public IActionResult TextArea()
        {
            if (Request.Method == "POST")
            {
                string str = Request.Form["text"];
                ViewBag.mess = str;
                return View();
            }
            return View();
        }
        public IActionResult CheckBox()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckBox(bool check)
        {
            ViewBag.mess = check;
            return View();
        }
        public IActionResult Radio()
        {
            if (Request.Method == "POST")
            {
                string str = Request.Form["month"];
                ViewBag.mess = str;
                return View();
            }
            return View();
        }
        public IActionResult DropDownList()
        {
            if (Request.Method == "POST")
            {
                string str = Request.Form["month"];
                ViewBag.mess = str;
                return View();
            }
            return View();
        }
        public IActionResult ListBox()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ListBox(string[] months)
        {
            string str = "";
            foreach (string m in months)
            {
                str += m;
                str += "; ";
            }
            ViewBag.mess = str;
            return View();
        }
    }
}
