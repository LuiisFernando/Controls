using Control.Domain.Entities;
using System.Collections.Generic;

namespace Control.Domain.Interfaces.Repositories
{
    public interface IMovimentacaoManualListarRepository : IRepositoryBase<MovimentacaoManualListar>
    {
        List<MovimentacaoManualListar> Listar();
    }
}
