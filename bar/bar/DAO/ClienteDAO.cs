using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_trab.VO;

namespace Teste_trab.DAO
{
    public class ClienteDAO : PadraoDAO
    {
       
        protected override string MontaSQLInsert()
        {
            return "Insert_Cliente";
        }

        protected override string MontaSQLUpdate()
        {
            return "Update_Cliente";
        }
        protected override  SqlParameter[] CriaParametros(PadraoVO o)
        {
            ClienteVO c = (o as ClienteVO);
            if (Consulta(o.Id) == null)
            {
                SqlParameter[] parametrosInclui =
            {

               new SqlParameter("Nome", c.Nome),
                new SqlParameter("CPF",c.CPF),
                new SqlParameter("Celular",c.Celular),
                new SqlParameter("CidadeID",c.CidadeID)

            };
                return parametrosInclui;
            }
            SqlParameter[] parametros =
            {
                
                new SqlParameter("ID",o.Id),
                new SqlParameter("Nome", c.Nome),
                new SqlParameter("CPF",c.CPF),
                new SqlParameter("Celular",c.Celular),
                new SqlParameter("CidadeID",c.CidadeID)
            };

            return parametros;
        }
       
     

        protected override PadraoVO MontaVO(DataRow dr)
        {

            ClienteVO c = new ClienteVO();
            c.Id = Convert.ToInt32(dr["id"]);
            c.Nome = dr["Nome"].ToString();
            c.CPF = dr["CPF"].ToString();
            c.Celular = dr["Celular"].ToString();
            c.CidadeID = Convert.ToInt32(dr["CidadeID"]);
            return c;
        }

        protected override string MontaSQLProximoId()
        {
            return "spProximoId";
        }

        protected override string MontaSQLPrimeiro()
        {
            return "sp_PrimeiroCliente";
        }

        protected override string MontaSQLUltimo()
        {
            return "sp_UltimoCliente";
        }

        protected override string MontaSQLProximo()
        {
            return "sp_ProximoCliente";
        }

        protected override string MontaSQLAnterior()
        {
            return "sp_AnteriorCliente";
        }

        protected override string MontaSQLDelete()
        {
            return "Delete_Cliente";
        }

        protected override string MontaSQLConsulta()
        {
            return "select_Cliente";
        }

        protected override string MontaSQLConsultaNome()
        {
            return "sp_PesquisaNomeCliente";
        }
        public virtual List<ClienteVO> ListarPorNome(string nome)
        {
            List<ClienteVO> retorno = new List<ClienteVO>();
            string sql = MontaSQLConsultaNome();
            SqlParameter[] p =
            {
                new SqlParameter("Nome", nome)
            };
            DataTable tabela = Metodos.ExecutaProcResultSet(sql, p);

            if (tabela.Rows.Count == 0)
                return null;
            else
                foreach (DataRow linha in tabela.Rows)
                    retorno.Add(MontaVO(linha) as ClienteVO);
            return retorno;

        }
    }
}
