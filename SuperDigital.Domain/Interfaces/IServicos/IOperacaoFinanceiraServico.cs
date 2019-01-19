using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Domain.Interfaces.IServicos
{
    public interface IOperacaoFinanceiraServico
    {
        bool Transferir(int contaOrigem, int contaDestino, decimal valor);
    }
}
