using System;

namespace Control.Domain.Entities
{
    public class MovimentoManual
    {
        public int DAT_MES { get; set; }
        public int DAT_ANO { get; set; }
        public int NUM_LANCAMENTO { get; set; }
        public int COD_PRODUTO { get; set; }
        public int COD_COSIF { get; set; }
        public decimal VAL_VALOR { get; set; }
        public string DES_DESCRICAO { get; set; }
        public DateTime DAT_MOVIMENTO { get; set; }
        public string COD_USUARIO { get; set; }
        public virtual ProdutoCosif ProdutoCosif { get; set; }
    }
}
