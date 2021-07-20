using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Aula04.Web.Models;
using Fiap.Aula04.Web.Persistencias;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Aula04.Web.Controllers
{
    public class CursoController : Controller
    {
        //Gerenciado de entidades
        private LmsContext _context;

        //Injeção de dependência pelo construtor
        public CursoController(LmsContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var curso = _context.Cursos.Find(id); //Pequisa pela PK
            _context.Cursos.Remove(curso); //Remove o curso
            _context.SaveChanges(); //Commit
            TempData["msg"] = "Curso removido!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var curso = _context.Cursos.Find(id);//Pesquisa o curso pela PK
            return View(curso);
        }

        [HttpPost]
        public IActionResult Editar(Curso curso)
        {
            _context.Attach(curso).State = EntityState.Modified; //Modifica o estado para modificado
            _context.SaveChanges(); //Commit
            TempData["msg"] = "Curso modificado!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Curso curso)
        {
            _context.Cursos.Add(curso); //Cadastra o curso no BD
            _context.SaveChanges(); //Commit
            TempData["msg"] = "Curso cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        public IActionResult Index()
        {
            var lista = _context.Cursos.ToList(); //Recupera todos os cursos do DB
            return View(lista);
        }
    }
}
