using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class AsignaturaController : Controller
    {

        public IActionResult Index()
        {
            return View(_context.Asignaturas.FirstOrDefault());
        }
        public IActionResult MultiAsignatura()
        {

            ViewBag.CosaDinamica = "Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura", _context.Asignaturas);

        }
        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context){

            _context = context;

        }
    }
}