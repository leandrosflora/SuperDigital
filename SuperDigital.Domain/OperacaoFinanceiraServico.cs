using SuperDigital.Domain.Interfaces.IRepositorios;
using SuperDigital.Domain.Interfaces.IServicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Domain
{
    public class OperacaoFinanceiraServico : IOperacaoFinanceiraServico
    {
        private readonly IContaRepositorio _contaReposiotiro; 

        public OperacaoFinanceiraServico(IContaRepositorio contaReposiotiro)
        {
            _contaReposiotiro = contaReposiotiro;
        }

        public bool Transferir(int contaOrigem, int contaDestino, decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
