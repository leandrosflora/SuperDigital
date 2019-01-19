using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Domain.Entidades
{
    public class Lancamentos
    {


        public ContaCorrente ContaOrigem { get; set; }

        public ContaCorrente ContaDestino { get; set; }

        public decimal Valor { get; set; }

        public void Transferir(ContaCorrente contaOrigem, ContaCorrente contaDestino, decimal valor)
        {
            contaOrigem.Debitar(valor);
            ContaDestino.Creditar(valor);
        }
    }
}
