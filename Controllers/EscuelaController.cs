using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers{
    public class EscuelaController : Controller{

        
        public IActionResult Index(){

            ViewBag.CosaDinamica = "Monja";
            var escuela = _context.Escuelas.FirstOrDefault();

            return View(escuela);

        }

        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context){

            _context = context;

        }
    }
}