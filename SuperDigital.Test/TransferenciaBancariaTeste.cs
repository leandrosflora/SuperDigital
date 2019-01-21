using SuperDigital.Domain;
using SuperDigital.Domain.Interfaces.IRepositorios;
using SuperDigital.Domain.Interfaces.IServicos;
using SuperDigital.Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SuperDigital.Test
{
    public class TransferenciaBancariaTeste
    {
        private OperacaoFinanceiraServico servico;
        private ContaRepositorioMoq repositorio;

        public void InicializarTestes()
        {
            this.repositorio = new ContaRepositorioMoq();
            this.servico = new OperacaoFinanceiraServico(repositorio);
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
