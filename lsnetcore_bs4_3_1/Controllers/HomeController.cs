﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lsnetcore_bs4_3_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello, World I!";
            ViewData["MessageTwo"] = "Hello, World II!";

            return View();
        }
    }
}