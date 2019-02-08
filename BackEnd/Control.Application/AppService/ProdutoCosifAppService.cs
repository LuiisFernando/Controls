using Control.Application.AppService.Interfaces;
using Control.Domain.Entities;
using Control.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Control.Application.AppService
{
    public class ProdutoCosifAppService : AppServiceBase<ProdutoCosif>, IProdutoCosifAppService
    {
        private IProdutoCosifService _service;

        public ProdutoCosifAppService(IProdutoCosifService service) : base(service)
        {
            this._service = service;
        }

        public List<ProdutoCosif> BuscarPorProduto(int COD_PRODUTO)
        {
            return this._service.FindAll(x => x.COD_PRODUTO == COD_PRODUTO).ToList();
        }
    }
}
