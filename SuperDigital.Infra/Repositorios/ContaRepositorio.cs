using Dapper;
using SuperDigital.Common;
using SuperDigital.Domain.Entidades;
using SuperDigital.Domain.Interfaces.IRepositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SuperDigital.Infra
{
    public class ContaRepositorio : Base.RepositorioBase, IContaRepositorio
    {
        public ContaRepositorio(FabricaConexao fabricaConexao) : base(fabricaConexao)
        {
        }

        public ContaCorrente Buscar(int conta)
        {
            //DynamicParameters parametros = new DynamicParameters();
            //parametros.Add("@numeroConta", conta, DbType.Int32);

            //using (IDbConnection conexao = this.FabricaConexao.CriarConexao())
            //{
            //    return conexao.QueryFirstOrDefault<ContaCorrente>(@"
            //        SELECT *
            //        FROM  Conta 
            //        WHERE Numero = @numeroConta", parametros);
            //}

            return new ContaCorrente()
            {
                Id = 1,
                Numero = 5,
                Lancamentos = new List<Lancamentos>()
            };
        }

        public void Salvar(ContaCorrente origem)
        {
            throw new NotImplementedException();
        }
    }
}
