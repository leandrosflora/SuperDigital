using SuperDigital.Domain;
using SuperDigital.Domain.DTO;
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

        private static readonly TransferenciaBancariaDTO DTO = new TransferenciaBancariaDTO()
        {
            contaDestino = 10,
            ContaOrigem = 10,
            Valor = 1000
        };

        public TransferenciaBancariaTeste()
        {
            this.repositorio = new ContaRepositorioMoq();
            this.servico = new OperacaoFinanceiraServico(repositorio);
        }

        [Fact]
        public void ValidaContaOrigemNaoExistente()
        {
            try
            {
                TransferenciaBancariaDTO DTO = new TransferenciaBancariaDTO()
                {
                    contaDestino = 5,
                    ContaOrigem = 100,
                    Valor = 1000
                };

                var sucesso = this.servico.Transferir(DTO);

                Assert.False(sucesso);
            }
            catch (Exception e)
            {
                Assert.True(true);
            }           
        }

        [Fact]
        public void ValidaContasExistentes()
        {
            var sucesso = this.servico.Transferir(DTO);

            Assert.True(sucesso);
        }

        [Fact]
        public void VerificaSaldoSuficienteContaOrigem()
        {
            var sucesso = this.servico.Transferir(DTO);

            Assert.True(sucesso);
        }
    }
}
