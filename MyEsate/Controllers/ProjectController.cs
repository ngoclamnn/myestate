﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEsate.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id = 0)
        {
            return View();
        }
        public ActionResult Overview(int id = 0)
        {
            return View();
        }
    }
}