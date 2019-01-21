using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace SuperDigital.Common
{
    public static class Transacao
    {
        public static void ExecutarEmTransacao(Action executarEmTransacao)
        {
            using (TransactionScope transacao = new TransactionScope())
            {
                executarEmTransacao();
                transacao.Complete();
            }
        }

        public static T ExecutarEmTransacao<T>(Func<T> executarEmTransacao)
        {
            using (TransactionScope transacao = new TransactionScope())
            {
                T resultado = executarEmTransacao();
                transacao.Complete();
                return resultado;
            }
        }
    }
}
