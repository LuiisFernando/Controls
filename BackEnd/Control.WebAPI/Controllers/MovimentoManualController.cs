using Control.Application.AppService.Interfaces;
using Control.Application.ViewModel;
using System;
using System.Web.Http;

namespace Control.WebAPI.Controllers
{
    [RoutePrefix("api/movimentoManual")]
    public class MovimentoManualController : ApiController
    {
        private readonly IMovimentoManualAppService _service;

        public MovimentoManualController(IMovimentoManualAppService service)
        {
            this._service = service;
        }

        [Route("adicionar"), HttpPost]
        public IHttpActionResult Adicionar(MovimentoManualVM model)
        {
            try
            {
                this._service.AdicionarMovimento(model);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("lista"), HttpGet]
        public IHttpActionResult Listar()
        {
            try
            {
                return Ok(this._service.Lista());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
