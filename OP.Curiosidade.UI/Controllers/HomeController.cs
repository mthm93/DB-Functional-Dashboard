using OP.Curiosidade.UI.Data;
using OP.Curiosidade.UI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web.Mvc;
using System.Web.Security;

namespace OP.Curiosidade.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly OPCuriosidadeDataContext ctx = new OPCuriosidadeDataContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login(string returnURL)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginVM model)
        {
            using (var ctx = new OPCuriosidadeDataContext())
            {
                var usuario = ctx.Usuarios.Where(w => w.Senha == model.Senha && w.Email == model.Email).FirstOrDefault();
                if (usuario != null && ModelState.IsValid)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);

                    return RedirectToAction("DashboardHome", "Home");
                }
            }

            return View();
        }

        [Authorize]
        public ActionResult DashboardHome()
        {
            IList<Colaborador> usuario = null;
            using (var ctx = new OPCuriosidadeDataContext())
            {
                usuario = ctx.Colaboradores.OrderByDescending(o => o.Data_Inicio).ToList();
            }

            ViewBag.Total = usuario.Count;
            ViewBag.TotalAtivo = usuario.Where(o => o.Email == "teste@hotmail.com").Count();
            
            return View(usuario);
        }

        public ActionResult DelProd(int id)
        {
            var colaborador = ctx.Colaboradores.Find(id);
            if (colaborador == null) 
            {
                return HttpNotFound();
            }

            ctx.Colaboradores.Remove(colaborador);
            ctx.SaveChanges();

            return null;
        }
    }
}

