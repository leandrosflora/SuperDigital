using System;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using SuperDigital.Domain.DTO;
using SuperDigital.Domain.Interfaces.IServicos;

namespace SuperDigital.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/TransferenciaBancaria")]
    public class TransferenciaController : Controller
    {
        private readonly IOperacaoFinanceiraServico _operacaoServico;

        public TransferenciaController(IOperacaoFinanceiraServico operacaoServico)
        {
            _operacaoServico = operacaoServico;
        }

        /// <summary>
        /// Efetua a Transferência entre contas correntes
        /// </summary>
        /// <param name="dadosTransferencia"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public HttpResponseMessage Post([FromBody] TransferenciaBancariaDTO dadosTransferencia)
        {
            try
            {
                //var sucesso = _operacaoServico.Transferir(dadosTransferencia);

                return new HttpResponseMessage(HttpStatusCode.OK);
                //if (sucesso)
                //    return new HttpResponseMessage(HttpStatusCode.OK);
                //else
                //    return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}