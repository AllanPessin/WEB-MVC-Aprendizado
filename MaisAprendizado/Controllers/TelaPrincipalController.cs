using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaisAprendizado.Controllers
{
    public class TelaPrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CriarCurso()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }
    }
}
