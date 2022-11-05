using BackendEjemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendEjemplo.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {

            ViewBag.Nombre = "Armando";
            ViewBag.Correo = "oavg30@gmail.com";
            ViewBag.Fecha = new DateTime(2000, 5, 5);
            return View();
        }
        public ActionResult Index2()
        {
            ViewData["Nombre"] = "Armando";
            ViewData["Correo"] = "oavg30@gmail.com";
            ViewData["Fecha"] = new DateTime(2000, 5, 5);
            return View();
        }
        public  ActionResult Vista()
        {
            var persona = new Persona()
            {
                Nombre = "Armando",
                Edad = 29,
                Empleado = true,
                Nacimiento = new DateTime(1993, 5, 6)
            };
            ViewBag.Propiedad = persona;
            return View();
        }
    }
}