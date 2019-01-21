using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SuperDigital.Common
{
    public class FabricaConexao
    {
        private IConfiguration configuracao;

        public string NomeConexao { get; set; }

        public FabricaConexao(IConfiguration configuracao)
        {
            this.configuracao = configuracao;
        }

        public IDbConnection CriarConexao() => new SqlConnection(this.configuracao.GetConnectionString(this.NomeConexao));
    }
}
