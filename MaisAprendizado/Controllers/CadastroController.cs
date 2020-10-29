using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MaisAprendizado.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Seletor()
        {
            return View();
        }
        public IActionResult Aluno()
        {
            return View();
        }
        public IActionResult Professor()
        {
            return View();
        }
    }

}
