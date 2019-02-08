using Control.Domain.Entities;
using Control.Domain.Interfaces.Repositories;
using Control.Domain.Interfaces.Services;

namespace Control.Domain.Services
{
    public class MovimentoManualService : ServiceBase<MovimentoManual>, IMovimentoManualService
    {
        IMovimentoManualRepository _repository;
        public MovimentoManualService(IMovimentoManualRepository repository)
            :base(repository)
        {
            this._repository = repository;
        }
    }
}
