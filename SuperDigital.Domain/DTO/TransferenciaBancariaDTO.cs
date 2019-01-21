using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Domain.DTO
{
    public class TransferenciaBancariaDTO
    {
        public int ContaOrigem { get; set; }

        public int contaDestino { get; set; }

        public decimal Valor { get; set; }
    }
}
