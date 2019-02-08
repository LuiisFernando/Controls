using Control.Domain.Entities;
using Control.Domain.Interfaces.Repositories;
using Control.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Control.Domain.Services
{
    public class MovimentacaoManualService : ServiceBase<MovimentacaoManualListar>, IMovimentacaoManualListarService
    {
        IMovimentacaoManualListarRepository _repository;
        public MovimentacaoManualService(IMovimentacaoManualListarRepository repository)
            : base (repository)
        {
            this._repository = repository;
        }

        public List<MovimentacaoManualListar> Listar()
        {
            return this._repository.Listar();
        }
    }
}
