using OP.Curiosidade.UI.Data;
using OP.Curiosidade.UI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OP.Curiosidade.UI.Controllers
{
    public class RelatoriosController : Controller
    {
 
        public ActionResult Relatorios()
        {

            IList<Colaborador> usuario = null;
            using (var ctx = new OPCuriosidadeDataContext())
            {
                usuario = ctx.Colaboradores.ToList();
            }

            return View(usuario);
        }

        public ActionResult RelatoriosImpressao()
        {

            IList<Colaborador> usuario = null;
            using (var ctx = new OPCuriosidadeDataContext())
            {
                usuario = ctx.Colaboradores.OrderBy(o => o.Nome).ToList();
            }

            return View(usuario);
        }
    }
}