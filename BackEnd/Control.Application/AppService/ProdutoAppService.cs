using Control.Application.AppService.Interfaces;
using Control.Domain.Entities;
using Control.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Control.Application.AppService
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private IProdutoService _service;

        public ProdutoAppService(IProdutoService service) : base(service)
        {
            this._service = service;
        }

        public List<Produto> ConsultarTodosProdutosAtivos()
        {
            return this._service.FindAll(x => x.STA_STATUS == "A").ToList();
        }
    }
}
