using Control.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Control.Infra.Data.EntityConfig
{
    public class ProdutoCosifConfig : EntityTypeConfiguration<ProdutoCosif>
    {
        public ProdutoCosifConfig()
        {
            ToTable("PRODUTO_COSIF");

            HasKey(e => new { e.COD_PRODUTO, e.COD_COSIF });

            Property(e => e.COD_CLASSIFICACAO)
                .HasMaxLength(6)
                .HasColumnType("char")
               .HasColumnName("COD_CLASSIFICACAO");

            Property(e => e.STA_STATUS)
               .HasColumnName("STA_STATUS");

            HasRequired(e => e.Produto)
                .WithMany(x => x.ProdutoConsifs)
                .HasForeignKey(e => e.COD_PRODUTO);
        }
    }
}
