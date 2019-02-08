using Control.Domain.Entities;
using Control.Domain.Interfaces.Repositories;
using Control.Domain.Interfaces.Services;

namespace Control.Domain.Services
{
    public class ProdutoCosifService : ServiceBase<ProdutoCosif>, IProdutoCosifService
    {
        IProdutoCosifRepository _repository;

        public ProdutoCosifService(IProdutoCosifRepository repository)
            :base(repository)
        {
            this._repository = repository;
        }
    }
}
