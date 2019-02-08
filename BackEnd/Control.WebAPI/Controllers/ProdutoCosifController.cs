using Control.Application.AppService.Interfaces;
using System;
using System.Web.Http;

namespace Control.WebAPI.Controllers
{
    [RoutePrefix("api/produtoCosif")]
    public class ProdutoCosifController : ApiController
    {
        private readonly IProdutoCosifAppService _produtoCosifAppService;

        public ProdutoCosifController(IProdutoCosifAppService produtoCosifAppService)
        {
            this._produtoCosifAppService = produtoCosifAppService;
        }

        [Route("consultarPorProduto/{COD_PRODUTO:int}"), HttpGet]
        public IHttpActionResult ConsultarPorProduto(int COD_PRODUTO)
        {
            try
            {
                var produtoCosifs = this._produtoCosifAppService.BuscarPorProduto(COD_PRODUTO);

                return Ok(produtoCosifs);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
