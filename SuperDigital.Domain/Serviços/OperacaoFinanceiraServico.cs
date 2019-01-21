using SuperDigital.Common;
using SuperDigital.Common.DTO;
using SuperDigital.Domain.Entidades;
using SuperDigital.Domain.Interfaces.IRepositorios;
using SuperDigital.Domain.Interfaces.IServicos;
using SuperDigital.Domain.Resource;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperDigital.Domain
{
    public class OperacaoFinanceiraServico : IOperacaoFinanceiraServico
    {
        private readonly IContaRepositorio _contaRepositorio; 

        public OperacaoFinanceiraServico(IContaRepositorio contaRepositorio)
        {
            _contaRepositorio = contaRepositorio;
        }

        public bool Transferir(TransferenciaBancariaDTO dadosTransferencia)
        {
            try
            {
                Transacao.ExecutarEmTransacao(() =>
                {
                    Lancamentos lancamento = new Lancamentos(dadosTransferencia.ContaOrigem, dadosTransferencia.contaDestino, dadosTransferencia.Valor);

                    ContaCorrente origem = _contaRepositorio.Buscar(dadosTransferencia.ContaOrigem);

                    ContaCorrente destino = _contaRepositorio.Buscar(dadosTransferencia.contaDestino);

                    if (origem == null || destino == null)
                        throw new ArgumentNullException(ValidationResource.ContaNaoExistente);

                    origem.Debitar(dadosTransferencia.Valor);

                    origem.Lancamentos.Add(lancamento);

                    destino.Creditar(dadosTransferencia.Valor);

                    _contaRepositorio.Salvar(origem);

                    _contaRepositorio.Salvar(destino);
                });

                return true;
            }
            catch (Exception e)
            {
                throw e;
            } 
        }
    }
}
