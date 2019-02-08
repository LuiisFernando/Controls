using Control.Domain.Entities;
using System.Collections.Generic;

namespace Control.Application.AppService.Interfaces
{
    public interface IProdutoCosifAppService
    {
        List<ProdutoCosif> BuscarPorProduto(int COD_PRODUTO);
    }
}
