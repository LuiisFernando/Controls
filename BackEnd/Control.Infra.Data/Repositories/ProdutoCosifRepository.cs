using Control.Domain.Entities;
using Control.Domain.Interfaces.Repositories;
using Control.Infra.Data.Context;

namespace Control.Infra.Data.Repositories
{
    public class ProdutoCosifRepository : RepositoryBase<ProdutoCosif>, IProdutoCosifRepository
    {
        public ProdutoCosifRepository(ControlContext context) : base(context)
        {

        }
    }
}
