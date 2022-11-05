﻿using BackendEjemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendEjemplo.Controllers
{
    public class VisParCochesController : Controller
    {
        // GET: VisParCoches
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _Garaje()
        {
            return View("_Garaje", new Garaje());
        }

        public ActionResult _GarajeSimple()
        {
            return View("_GarajeSimple", new Garaje());
        }
    }
}