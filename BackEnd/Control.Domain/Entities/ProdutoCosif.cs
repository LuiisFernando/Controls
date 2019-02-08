using System.Collections.Generic;

namespace Control.Domain.Entities
{
    public class ProdutoCosif
    {
        public ProdutoCosif()
        {
            MovimentoManuals = new List<MovimentoManual>();
        }
        public int COD_PRODUTO { get; set; }
        public int COD_COSIF { get; set; }
        public string COD_CLASSIFICACAO { get; set; }
        public string STA_STATUS { get; set; }

        public virtual Produto Produto { get; set; }

        public virtual ICollection<MovimentoManual> MovimentoManuals { get; set; }
    }
}
