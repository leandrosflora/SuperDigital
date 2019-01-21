using SuperDigital.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperDigital.Infra.Base
{
    public abstract class RepositorioBase
    {
        protected FabricaConexao FabricaConexao { get; private set; }

        public RepositorioBase(FabricaConexao fabrica)
        {
            this.FabricaConexao = fabrica;
            this.FabricaConexao.NomeConexao = "connectionStringDB";
        }
    }
}
