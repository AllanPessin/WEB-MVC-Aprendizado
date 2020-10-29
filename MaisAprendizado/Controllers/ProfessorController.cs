using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaisAprendizado.Data;
using MaisAprendizado.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaisAprendizado.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: ProfessorController
        public ActionResult Professor(Pessoa pessoa)
        {
            return View(pessoa);
        }

        // GET: ProfessorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfessorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfessorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection pessoa)
        {
            int PessoaId = -1;
            string nome = pessoa["nome"];   //<input name = "nome"
            string email = pessoa["email"]; //<input emal = "email"
            string senha = pessoa["senha"]; //<input senha = "senha"
            string dataNascimento = pessoa["datanascimento"];
            string telefone = pessoa["telefone"];
            var dataNasc = DateTime.Parse(dataNascimento);

            var novaPessoa = new Pessoa();
            novaPessoa.Nome =  pessoa["nome"];
            novaPessoa.Email =  pessoa["email"];
            novaPessoa.Senha =  pessoa["senha"];
            novaPessoa.DataNascimento = pessoa["datanascimento"];
            novaPessoa.Telefone =  pessoa["telefone"];

            var professor = new Professor();
            professor.Nome = pessoa["nome"];
            professor.Email = pessoa["email"];
            professor.Senha = pessoa["senha"];
            professor.DataNascimento = pessoa["datanascimento"];
            professor.Telefone = pessoa["telefone"];
            try
            {
                using (var data = new PessoaData())
                 novaPessoa.PessoaId = data.Create(novaPessoa);
                using (var professordata = new ProfessorData())
                    professordata.Create(professor, novaPessoa);
                ViewBag.Message = "Sucesso Cadastro";
                return View();



            }
            catch
            {
                ViewBag.Message = "Erro Cadastro";
                return View();
            }
        }

        // GET: ProfessorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfessorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfessorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfessorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
