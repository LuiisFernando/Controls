using Control.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Control.Infra.Data.EntityConfig
{
    public class MovimentoManualConfig : EntityTypeConfiguration<MovimentoManual>
    {
        public MovimentoManualConfig()
        {
            HasKey(e => new { e.DAT_MES, e.DAT_ANO, e.NUM_LANCAMENTO, e.COD_PRODUTO, e.COD_COSIF });

            Property(e => e.DES_DESCRICAO)
                .HasMaxLength(50)
               .HasColumnName("DES_DESCRICAO");

            Property(e => e.DAT_MOVIMENTO)
                .HasColumnType("smalldatetime")
               .HasColumnName("DAT_MOVIMENTO");

            Property(e => e.COD_USUARIO)
                .HasMaxLength(50)
               .HasColumnName("COD_USUARIO");

            Property(e => e.VAL_VALOR)
                .HasPrecision(18, 2)
               .HasColumnName("VAL_VALOR");
        }
    }
}
