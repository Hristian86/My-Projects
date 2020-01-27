﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Data.Models;
using Phonebook.Data;

namespace Phonebook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(DataAccess.Contacts);
        }
    }
}