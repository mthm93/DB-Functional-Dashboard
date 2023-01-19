using OP.Curiosidade.UI.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OP.Curiosidade.UI.Data
{
    public class OPCuriosidadeDataContext:DbContext
    {
        public OPCuriosidadeDataContext() : base("OPConn")
        {
            Database.SetInitializer<OPCuriosidadeDataContext>(null);
        }

        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}