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
    public class FornecedorDAO : PadraoDAO
    {
        protected override string MontaSQLInsert()
        {
            return "insert_Fornecedor";
        }

        protected override string MontaSQLUpdate()
        {
            return "Update_Fornecedor";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            
            FornecedorVO t = (o as FornecedorVO);
            if(Consulta(o.Id) == null)
            {
                SqlParameter[]parametrosInclui =
            {

                new SqlParameter("Nome", t.Nome),
                new SqlParameter("CNPJ", t.Cnpj),
                new SqlParameter("Telefone", t.Telefone),
                new SqlParameter("CidadeID", t.CidadeID)

            };
                return parametrosInclui;
            }
            
            SqlParameter[] parametros =
            {
            
                new SqlParameter("ID", o.Id),
                new SqlParameter("Nome", t.Nome),
                new SqlParameter("CNPJ", t.Cnpj),
                new SqlParameter("Telefone", t.Telefone),
                new SqlParameter("CidadeID", t.CidadeID)
                  
            };

            return parametros;
        }



        protected override PadraoVO MontaVO(DataRow dr)
        {

            FornecedorVO t = new FornecedorVO();
            t.Id = Convert.ToInt32(dr["ID"]);
            t.Nome = dr["Nome"].ToString();
            t.Cnpj = dr["CNPJ"].ToString();
            t.Telefone = dr["Telefone"].ToString();
            t.CidadeID = Convert.ToInt32(dr["CidadeID"]);
            return t;
        }

        protected override string MontaSQLProximoId()
        {
            return "spProximoIdFornecedor";
        }

        protected override string MontaSQLPrimeiro()
        {
            return "sp_PrimeiroFornecedor";
        }

        protected override string MontaSQLUltimo()
        {
            return "sp_UltimoFornecedor";
        }

        protected override string MontaSQLProximo()
        {
            return "sp_ProximoFornecedor";
        }

        protected override string MontaSQLAnterior()
        {
            return "sp_AnteriorFornecedor";
        }

        protected override string MontaSQLDelete()
        {
            return "delete_fornecedor";
        }

        protected override string MontaSQLConsulta()
        {
            return "SP_PesquisaFornecedor";
        }

        protected override string MontaSQLConsultaNome()
        {
            return "SP_PesquisaNomeFornecedor";
        }
        public virtual List<FornecedorVO> ListarPorFornecedor(string nome)
        {
            List<FornecedorVO> retorno = new List<FornecedorVO>();
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
                    retorno.Add(MontaVO(linha) as FornecedorVO);
            return retorno;

        }
    }
}
