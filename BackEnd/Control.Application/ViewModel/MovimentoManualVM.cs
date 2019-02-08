using Control.Domain.Entities;
using System;

namespace Control.Application.ViewModel
{
    public class MovimentoManualVM
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

        public static MovimentoManual getEntity(MovimentoManualVM model)
        {
            var movimento = new MovimentoManual();

            movimento.DAT_MES = model.DAT_MES;
            movimento.DAT_ANO = model.DAT_ANO;
            movimento.NUM_LANCAMENTO = model.NUM_LANCAMENTO;
            movimento.COD_PRODUTO = model.COD_PRODUTO;
            movimento.COD_COSIF = model.COD_COSIF;
            movimento.VAL_VALOR = model.VAL_VALOR;
            movimento.DES_DESCRICAO = model.DES_DESCRICAO;
            movimento.DAT_MOVIMENTO = model.DAT_MOVIMENTO;
            movimento.COD_USUARIO = model.COD_USUARIO;

            return movimento;
        }
    }
}
