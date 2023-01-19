using OP.Curiosidade.UI.Data;
using OP.Curiosidade.UI.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace OP.Curiosidade.UI.Controllers
{
    public class CadastroController : Controller
    {
        private readonly OPCuriosidadeDataContext _ctx = new OPCuriosidadeDataContext();

        [HttpGet]
        public ViewResult Cadastro(int? id)
        {
            Colaborador colaborador = new Colaborador();

            if (id != null)
            {
                colaborador = _ctx.Colaboradores.Where(w => w.Id_Usuario == id).FirstOrDefault();
            }

            return View(colaborador);
        }

        [HttpPost]
        public ActionResult Cadastro(Colaborador colaborador)
        {
                if (colaborador.Id_Usuario == 0)
                {
                    _ctx.Colaboradores.Add(colaborador);
                }
                else
                {
                    _ctx.Entry(colaborador).State = EntityState.Modified;
                }
                _ctx.SaveChanges();

                return RedirectToAction("DashboardHome", "Home");
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}
