namespace Control.Infra.Data.Migrations
{
    using Control.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Control.Infra.Data.Context.ControlContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Control.Infra.Data.Context.ControlContext context)
        {
            context.Produtos.AddOrUpdate(
                new Produto { COD_PRODUTO = 1, DESC_PRODUTO = "Produto 1", STA_STATUS = "A" },
                new Produto { COD_PRODUTO = 2, DESC_PRODUTO = "Produto 2", STA_STATUS = "A" },
                new Produto { COD_PRODUTO = 3, DESC_PRODUTO = "Produto 3", STA_STATUS = "A" },
                new Produto { COD_PRODUTO = 4, DESC_PRODUTO = "Produto 4", STA_STATUS = "A" },
                new Produto { COD_PRODUTO = 5, DESC_PRODUTO = "Produto 5", STA_STATUS = "A" }
            );

            context.ProdutoCosifs.AddOrUpdate(
                new ProdutoCosif { COD_PRODUTO = 1, COD_COSIF = 500, COD_CLASSIFICACAO="Normal", STA_STATUS = "A" },
                new ProdutoCosif { COD_PRODUTO = 2, COD_COSIF = 404, COD_CLASSIFICACAO = "MTM" , STA_STATUS = "A"},
                new ProdutoCosif { COD_PRODUTO = 3, COD_COSIF = 503, COD_CLASSIFICACAO = "Normal", STA_STATUS = "A" },
                new ProdutoCosif { COD_PRODUTO = 4, COD_COSIF = 401, COD_CLASSIFICACAO = "Normal", STA_STATUS = "A" },
                new ProdutoCosif { COD_PRODUTO = 5, COD_COSIF = 501, COD_CLASSIFICACAO = "MTM" , STA_STATUS = "A"}
            );
        }
    }
}