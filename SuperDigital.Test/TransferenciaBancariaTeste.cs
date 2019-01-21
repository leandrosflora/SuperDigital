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

        private OperacaoFinanceiraServico _operacao;
        private readonly IContaRepositorio _contaRepositorio;

        public TransferenciaBancariaTeste(IContaRepositorio contaRepositorio)
        {
            _contaRepositorio = contaRepositorio;
            _operacao = new OperacaoFinanceiraServico(_contaRepositorio);
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
