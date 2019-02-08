using Control.Domain.Entities;
using System.Collections.Generic;

namespace Control.Application.AppService.Interfaces
{
    public interface IProdutoAppService
    {
        List<Produto> ConsultarTodosProdutosAtivos();
    }
}
