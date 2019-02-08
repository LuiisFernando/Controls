using Control.Application.AppService.Interfaces;
using System;
using System.Web.Http;

namespace Control.WebAPI.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoController(IProdutoAppService produtoAppService)
        {
            this._produtoAppService = produtoAppService;
        }

        [Route("consultarProdutosAtivos"), HttpGet]
        public IHttpActionResult ConsultarTodosProdutosAtivos()
        {
            try
            {
                var todosProdutosAtivos = this._produtoAppService.ConsultarTodosProdutosAtivos();

                return Ok(todosProdutosAtivos);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
