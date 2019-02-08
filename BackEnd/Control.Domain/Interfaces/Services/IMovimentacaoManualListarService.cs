using Control.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Domain.Interfaces.Services
{
    public interface IMovimentacaoManualListarService : IServiceBase<MovimentacaoManualListar>
    {
        List<MovimentacaoManualListar> Listar();
    }
}
