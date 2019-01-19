using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Domain.Entidades
{
    public class Lancamentos
    {
        public Lancamentos(int contaOrigem, int contaDestino, decimal valor)
        {
            ContaOrigem = ContaOrigem;
            ContaDestino = contaDestino;
            Valor = valor;
        }

        public long Id { get; set; }

        public int ContaOrigem { get; set; }

        public int ContaDestino { get; set; }

        public decimal Valor { get; set; }
    }
}
