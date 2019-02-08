using Control.Application.AppService.Interfaces;
using Control.Application.ViewModel;
using Control.Domain.Entities;
using Control.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Control.Application.AppService
{
    public class MovimentoManualAppService : AppServiceBase<MovimentoManual>, IMovimentoManualAppService
    {
        private IMovimentoManualService _service;
        private IMovimentacaoManualListarService _serviceListar;

        public MovimentoManualAppService(IMovimentoManualService service, IMovimentacaoManualListarService serviceListar) : base(service)
        {
            this._service = service;
            this._serviceListar = serviceListar;
        }

        public void AdicionarMovimento(MovimentoManualVM movimentoVM)
        {
            try
            {
                var movimentacaoBanco = this._service.FindAll(x => x.DAT_MES == movimentoVM.DAT_MES && x.DAT_ANO == movimentoVM.DAT_ANO).OrderByDescending(x => x.NUM_LANCAMENTO).ToList();

                var movimento = MovimentoManualVM.getEntity(movimentoVM);

                if (movimentacaoBanco.Count == 0 || movimentacaoBanco == null)
                    movimento.NUM_LANCAMENTO = 1;
                else
                    movimento.NUM_LANCAMENTO = movimentacaoBanco[0].NUM_LANCAMENTO + 1;

                movimento.COD_USUARIO = "TESTE";
                movimento.DAT_MOVIMENTO = DateTime.Now;

                this._service.Insert(movimento);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public List<MovimentacaoManualListar> Lista()
        {
            return this._serviceListar.Listar();
        }
    }
}
