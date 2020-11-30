using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Views.cadastro
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroUsuario(string nome, string email, string senha, DateTime nascimento)
        {
            return View();
        }
    }
}