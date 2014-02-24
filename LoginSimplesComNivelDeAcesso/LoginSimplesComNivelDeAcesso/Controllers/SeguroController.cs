using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginSimplesComNivelDeAcesso.Helpers;

namespace LoginSimplesComNivelDeAcesso.Controllers
{
    public class SeguroController : Controller
    {
        [Seguranca(Permissao = "administrador")]
        public ActionResult Index()
        {
            return View();
        }
    }
}