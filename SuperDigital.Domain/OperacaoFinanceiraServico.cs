using SuperDigital.Domain.Entidades;
using SuperDigital.Domain.Interfaces.IRepositorios;
using SuperDigital.Domain.Interfaces.IServicos;
using SuperDigital.Domain.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Domain
{
    public class OperacaoFinanceiraServico : IOperacaoFinanceiraServico
    {
        private readonly IContaRepositorio _contaRepositorio; 

        public OperacaoFinanceiraServico(IContaRepositorio contaRepositorio)
        {
            _contaRepositorio = contaRepositorio;
        }

        public bool Transferir(int contaOrigem, int contaDestino, decimal valor)
        {
            try
            {
                Lancamentos lancamento = new Lancamentos(contaOrigem, contaDestino, valor);

                ContaCorrente origem = _contaRepositorio.Buscar(contaOrigem);

                ContaCorrente destino = _contaRepositorio.Buscar(contaDestino);

                origem.Debitar(valor);

                origem.Lancamentos.Add(lancamento);

                destino.Creditar(valor);

                _contaRepositorio.Salvar(origem);

                _contaRepositorio.Salvar(destino); 

                return true;
            }
            catch (Exception e)
            {
                throw e;
            } 
        }
    }
}
