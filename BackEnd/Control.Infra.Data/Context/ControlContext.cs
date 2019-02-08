using Control.Domain.Entities;
using Control.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Control.Infra.Data.Context
{
    public class ControlContext : DbContext
    {
        public ControlContext()
            : base("ControlConnectionString")
        {
            Database.SetInitializer<ControlContext>(null);
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.CommandTimeout = 300;
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoCosif> ProdutoCosifs { get; set; }
        public DbSet<MovimentoManual> MovimentoManuals { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /********************************************
             *            Configurações Globais
             ********************************************/
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            modelBuilder.Configurations.Add(new ProdutoConfig());
            modelBuilder.Configurations.Add(new ProdutoCosifConfig());
            modelBuilder.Configurations.Add(new MovimentoManualConfig());

        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
