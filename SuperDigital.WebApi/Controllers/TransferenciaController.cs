using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperDigital.Domain.Interfaces.IServicos;

namespace SuperDigital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferenciaController : ControllerBase
    {
        private readonly IOperacaoFinanceiraServico _operacaoServico;

        public TransferenciaController(IOperacaoFinanceiraServico operacaoServico)
        {
            _operacaoServico = operacaoServico;
        } 

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public HttpResponseMessage Post([FromBody] int contaOrigem, int contaDestino, decimal valor)
        {
            try
            {
                var sucesso = _operacaoServico.Transferir(contaOrigem, contaDestino, valor);

                if (sucesso)
                    return new HttpResponseMessage(HttpStatusCode.OK);
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}