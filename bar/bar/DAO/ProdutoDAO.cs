using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_trab.DAO;
using Teste_trab.VO;
using Teste_trab.Enumeradores;
using System.Data;
using System.Data.SqlClient;

namespace Teste_trab.DAO
{
    public class ProdutoDAO : PadraoDAO
    {
        protected override string MontaSQLInsert()
        {
            return "insert_Produtos";
        }

        protected override string MontaSQLUpdate()
        {
            return "update_produtos";
        }
        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {

            ProdutoVO p = (o as ProdutoVO);
            if (Consulta(o.Id) == null)
            {
                SqlParameter[] parametrosInclui =
            {
                    
                new SqlParameter("Descricao", p.Descricao),
                new SqlParameter("ValorCompra", p.ValorCompra),
                new SqlParameter("ValorVenda", p.ValorVenda),
                new SqlParameter("FornecedorID", p.FornecedorID),
                new SqlParameter("Volume",p.Volume),
                new SqlParameter("Imagem",p.Imagem)

            };
                return parametrosInclui;
            }

            SqlParameter[] parametros =
            {

                new SqlParameter("ID", o.Id),
                 new SqlParameter("Descricao", p.Descricao),
                new SqlParameter("ValorCompra", p.ValorCompra),
                new SqlParameter("ValorVenda", p.ValorVenda),
                new SqlParameter("FornecedorID", p.FornecedorID),
                new SqlParameter("Volume",p.Volume)

            };

            return parametros;
        }



        protected override PadraoVO MontaVO(DataRow dr)
        {

            ProdutoVO p = new ProdutoVO();
            p.Id = Convert.ToInt32(dr["ID"]);
            p.Descricao = dr["Descricao"].ToString();
            p.ValorCompra= Convert.ToDouble(dr["ValorCompra"]);
            p.ValorVenda = Convert.ToDouble(dr["ValorCompra"]);
            p.FornecedorID = Convert.ToInt32(dr["FornecedorID"]);
            p.Volume = Convert.ToDouble(dr["Volume"]);
            p.Imagem = dr["imagem"].ToString();
            return p;
        }

        protected override string MontaSQLProximoId()
        {
            return "spProximoId";
        }

        protected override string MontaSQLPrimeiro()
        {
            return "sp_PrimeiroProduto";
        }

        protected override string MontaSQLUltimo()
        {
            return "sp_UltimoProduto";
        }

        protected override string MontaSQLProximo()
        {
            return "sp_ProximoProduto";
        }

        protected override string MontaSQLAnterior()
        {
            return "sp_AnteriorProduto";
        }

        protected override string MontaSQLDelete()
        {
            return "delete_produto";
        }

        protected override string MontaSQLConsulta()
        {
            return "SP_PesquisaProduto";
        }

        protected override string MontaSQLConsultaNome()
        {
            return "SP_PesquisaNomeProduto";
        }
        public virtual List<ProdutoVO> ListarPorProduto(string nome)
        {
            List<ProdutoVO> retorno = new List<ProdutoVO>();
            string sql = MontaSQLConsultaNome();
            SqlParameter[] p =
            {
                new SqlParameter("nome", nome)
            };
            DataTable tabela = Metodos.ExecutaProcResultSet(sql, p);

            if (tabela.Rows.Count == 0)
                return null;
            else
                foreach (DataRow linha in tabela.Rows)
                    retorno.Add(MontaVO(linha) as ProdutoVO);
            return retorno;

        }
    }
}
