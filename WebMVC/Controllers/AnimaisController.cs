using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;
using WebMVC.Servicos;

namespace WebMVC.Controllers
{
    public class AnimaisController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(string nome)
        {
            AnimalServico.Instancia().Add(new Animal() { 
                Nome = nome
            });

            ViewBag.mensagem = "Cadastrado com sucesso";
            return View();
        }
    }
}