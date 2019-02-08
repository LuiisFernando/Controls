using Control.Domain.Entities;
using Control.Domain.Interfaces.Repositories;
using Control.Infra.Data.Context;

namespace Control.Infra.Data.Repositories
{
    public class MovimentoManualRepository : RepositoryBase<MovimentoManual>, IMovimentoManualRepository
    {
        public MovimentoManualRepository(ControlContext context) : base(context)
        {

        }
    }
}
