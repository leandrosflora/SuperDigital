using SuperDigital.Domain;
using SuperDigital.Domain.Interfaces.IRepositorios;
using SuperDigital.Domain.Interfaces.IServicos;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SuperDigital.Test
{
    public class TransferenciaBancariaTeste
    {
        private readonly IOperacaoFinanceiraServico _operacao; 

        public TransferenciaBancariaTeste(IOperacaoFinanceiraServico operacao)
        { 
            _operacao = operacao;
        }

        [Fact]
        public void VerificaContaDestinoExistente()
        {


            Assert.True(true);
        }

        [Fact]
        public void VerificaContaOrigemExistente()
        {

        }

        [Fact]
        public void VerificaSaldoSuficienteContaOrigem()
        {

        }
    }
}
