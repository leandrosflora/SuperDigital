using Moq;
using SuperDigital.Domain.DTO;
using SuperDigital.Domain.Entidades;
using SuperDigital.Domain.Interfaces.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Moq
{
    public class ContaRepositorioMoq : RepositorioBaseMoq<IContaRepositorio>, IContaRepositorio
    {
        public ContaCorrente Conta { get; set; }

        public ContaRepositorioMoq()
        {
            this.Conta = new ContaCorrente()
            {
                Id = 123,
                Numero = 10
            };

            this.Mock.Setup(m => m.Salvar(It.IsAny<ContaCorrente>()));

            this.Mock.Setup(m => m.Buscar(It.IsAny<int>())).Returns(() => this.Conta);
        }

        public ContaCorrente Buscar(int contaOrigem)
        {
            return this.Mock.Object.Buscar(contaOrigem);
        }

        public void Salvar(ContaCorrente origem)
        {
            this.Mock.Object.Salvar(origem);
        }
    }
}
