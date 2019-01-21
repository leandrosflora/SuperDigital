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

        public ContaCorrente Buscar(int contaOrigem)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", contaOrigem, DbType.Int64);

            using (IDbConnection conexao = this.FabricaConexao.CriarConexao())
            {
                return conexao.QueryFirstOrDefault<ContaCorrente>(@"
                    SELECT *
                    FROM  ArquivoUpload AS td JOIN ArquivoAnexado AS aa
                            ON td.IdArquivoAnexado = aa.Id
                    WHERE td.Id = @id", parametros);
            }
        }

        public void Salvar(ContaCorrente origem)
        {
            throw new NotImplementedException();
        }
    }
}
