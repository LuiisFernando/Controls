using Control.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Control.Infra.Data.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            ToTable("PRODUTO");

            HasKey(x => x.COD_PRODUTO)
               .Property(x => x.COD_PRODUTO)
               .HasColumnName("COD_PRODUTO");

            Property(e => e.DESC_PRODUTO)
                .HasMaxLength(30)
               .HasColumnName("DESC_PRODUTO");

            Property(e => e.STA_STATUS)
               .HasColumnName("STA_STATUS");
        }
    }
}
