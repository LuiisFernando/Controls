using Control.Domain.Entities;
using Control.Domain.Interfaces.Repositories;
using Control.Infra.Data.Context;

namespace Control.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ControlContext context) : base(context)
        {

        }
    }
}
