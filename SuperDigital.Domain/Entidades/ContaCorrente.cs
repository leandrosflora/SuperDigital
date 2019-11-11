using SuperDigital.Domain.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Domain.Entidades
{
    public class ContaCorrente : Conta
    {
        private readonly decimal LimiteChequeEspecial = 5000;

        public new void Debitar(decimal valor)
        {
            if (this.ValorTotal - valor >= -LimiteChequeEspecial)
            {
                base.Debitar(valor);
            }
            else
            {
                throw new Exception(ValidationResource.LimiteUltrapassado);
            }
        }

        public new void Creditar(decimal valor)
        {
            this.ValorTotal += valor;
        }
    }
}
