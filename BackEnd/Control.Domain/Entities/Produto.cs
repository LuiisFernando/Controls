using System.Collections.Generic;

namespace Control.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            ProdutoConsifs = new List<ProdutoCosif>();
        }
        public int COD_PRODUTO { get; set; }
        public string DESC_PRODUTO { get; set; }

        public string STA_STATUS { get; set; }

        public virtual ICollection<ProdutoCosif> ProdutoConsifs { get; set; }

    }
}
