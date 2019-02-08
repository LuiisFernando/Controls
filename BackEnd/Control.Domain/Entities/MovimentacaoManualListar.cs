namespace Control.Domain.Entities
{
    public class MovimentacaoManualListar
    {
        public int DAT_MES { get; set; }
        public int DAT_ANO { get; set; }

        public int COD_PRODUTO { get; set; }

        public string DESC_PRODUTO { get; set; }
        public int NUM_LANCAMENTO { get; set; }
        public string DES_DESCRICAO { get; set; }
        public decimal VAL_VALOR { get; set; }
    }
}
