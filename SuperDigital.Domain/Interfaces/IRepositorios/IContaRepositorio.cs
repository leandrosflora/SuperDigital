using System;
using System.Collections.Generic;
using System.Text;
using SuperDigital.Domain.Entidades;

namespace SuperDigital.Domain.Interfaces.IRepositorios
{
    public interface IContaRepositorio
    {
        ContaCorrente Buscar(int contaOrigem);

        void Salvar(ContaCorrente origem);
    }
}
