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
    public class CidadeDAO : PadraoDAO
    {
        public virtual List<CidadeVO> ListarPorNome(string nome)
        {
            List<CidadeVO> retorno = new List<CidadeVO>();
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
                    retorno.Add(MontaVO(linha) as CidadeVO);
            return retorno;

        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            throw new NotImplementedException();
        }

        protected override string MontaSQLAnterior()
        {
            throw new NotImplementedException();
        }

        protected override string MontaSQLConsulta()
        {
            return "0";
            //throw new NotImplementedException();
        }

        protected override string MontaSQLConsultaNome()
        {
            return "sp_PesquisaCidade";
        }

        protected override string MontaSQLDelete()
        {
            throw new NotImplementedException();
        }

        protected override string MontaSQLInsert()
        {
            throw new NotImplementedException();
        }

        protected override string MontaSQLPrimeiro()
        {
            throw new NotImplementedException();
        }

        protected override string MontaSQLProximo()
        {
            throw new NotImplementedException();
        }

        protected override string MontaSQLProximoId()
        {
            throw new NotImplementedException();
        }

        protected override string MontaSQLUltimo()
        {
            throw new NotImplementedException();
        }

        protected override string MontaSQLUpdate()
        {
            throw new NotImplementedException();
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            CidadeVO c = new CidadeVO();
            c.Id = Convert.ToInt32(dr["id"]);
            c.Cidade = dr["cidade"].ToString();
            c.UfID = Convert.ToInt32(dr["UFID"]);
            
            return c;
        }
    }
}
