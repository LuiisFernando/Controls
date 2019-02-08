using Control.Domain.Entities;
using Control.Domain.Interfaces.Repositories;
using Control.Domain.Interfaces.Services;

namespace Control.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
            : base(repository)
        {
            this._repository = repository;
        }

    }
}
