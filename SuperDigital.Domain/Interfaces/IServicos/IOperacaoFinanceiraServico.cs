using SuperDigital.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperDigital.Domain.Interfaces.IServicos
{
    public interface IOperacaoFinanceiraServico
    {
        bool Transferir(TransferenciaBancariaDTO dados);
    }
}
