using BackendEjemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendEjemplo.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Index()
        {
            var model = new pelicula();
            return View(model);
        }

        public ActionResult Index2()
        {
            var model = new pelicula();
            return View(model);
        }


    }
}