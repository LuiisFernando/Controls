using Control.Application.AppService;
using Control.Application.AppService.Interfaces;
using Control.Domain.Interfaces.Repositories;
using Control.Domain.Interfaces.Services;
using Control.Domain.Services;
using Control.Infra.Data.Context;
using Control.Infra.Data.Repositories;
using SimpleInjector;

namespace Control.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ControlContext>(Lifestyle.Scoped);

            #region AppService

            container.Register<IProdutoAppService, ProdutoAppService>();
            container.Register<IProdutoCosifAppService, ProdutoCosifAppService>();
            container.Register<IMovimentoManualAppService, MovimentoManualAppService>();

            #endregion

            #region 'Inject Service'

            container.Register<IProdutoService, ProdutoService>();
            container.Register<IProdutoCosifService, ProdutoCosifService>();
            container.Register<IMovimentoManualService, MovimentoManualService>();
            container.Register<IMovimentacaoManualListarService, MovimentacaoManualService>();

            #endregion

            #region 'Inject Repository'

            container.Register<IProdutoRepository, ProdutoRepository>();
            container.Register<IProdutoCosifRepository, ProdutoCosifRepository>();
            container.Register<IMovimentoManualRepository, MovimentoManualRepository>();
            container.Register<IMovimentacaoManualListarRepository, MovimentacaoManualListarRepository>();

            #endregion
        }
    }
}
