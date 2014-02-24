using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LoginSimplesComNivelDeAcesso.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Login, string Senha)
        {
            if (Login == "admin" && Senha == "admin")
            {
                var userName = Login;
                var lembrar = false;
                //Setar o grupo do usuário quando ele logar. Ex.: Buscar o grupo do banco e setar
                Session["permissao"] = "administrador";
                FormsAuthentication.SetAuthCookie(userName, lembrar);
                return RedirectToAction("Index", "Seguro");
            }
            return View();
        }

        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}