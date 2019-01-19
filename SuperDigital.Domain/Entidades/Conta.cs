using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Domain.Entidades
{
    public abstract class Conta
    {
        public long Id { get; set; }

        public long Numero { get; set; } 

        protected decimal ValorTotal { get; set; }

        public List<Lancamentos> Lancamentos { get; set; }

        public void Debitar(decimal valor)
        {
            this.ValorTotal -= valor;
        }

        public void Creditar(decimal valor)
        {   
            this.ValorTotal += valor;
        }

        public decimal Saldo()
        {           
            return this.ValorTotal;
        }
    }
}
