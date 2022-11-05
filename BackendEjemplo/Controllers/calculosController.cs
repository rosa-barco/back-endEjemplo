using BackendEjemplo.Models;
using BackendEjemplo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendEjemplo.Controllers
{
    public class calculosController : Controller
    {
        // GET: calculos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Suma(string n1, string n2)
        {
            int res = 0;
            res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.res = res;
            
            return View();
        }
        public ActionResult Operacion()
        {
            operasbas op = new operasbas();
            return View(op);
        }
        [HttpPost]
        public ActionResult Operacion(operasbas op)
        {
            op.Suma();
            return View(op);
        }
        public ActionResult Resta(operasbas op)
        {
            op.Resta();
            return View(op);
        }
        public ActionResult MuestraPeliculas()
        {
            var peliculaservice = new PeliculaService();
            var model = peliculaservice.ObtenerPeliculas();

            return View(model);
        }
        public ActionResult MuestraPeliculas2()
        {
            var peliculaservice = new PeliculaService();
            var model = peliculaservice.ObtenerPeliculas();

            return View(model);
        }
        public RedirectToRouteResult Temporal()
        {
            //return Content("<h1>hola mundo</h1>");
            //var alumno1 = new Alumno() { Nombre = "juan", Edad = 20 };
            //return Json(alumno1, JsonRequestBehavior.AllowGet);
            return RedirectToAction("About","Home");

        }
    }
}