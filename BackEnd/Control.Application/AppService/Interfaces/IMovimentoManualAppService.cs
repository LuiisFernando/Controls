using Control.Application.ViewModel;
using Control.Domain.Entities;
using System.Collections.Generic;

namespace Control.Application.AppService.Interfaces
{
    public interface IMovimentoManualAppService
    {
        void AdicionarMovimento(MovimentoManualVM movimentoVM);

        List<MovimentacaoManualListar> Lista();
    }
}
