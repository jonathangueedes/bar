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
    public class VendaDAO 
    {

        protected static SqlParameter[] CriaParametros(PadraoVO o)
        {

            VendaVO t = (o as VendaVO);
            if (Consulta(o.Id) == null)
            {
                SqlParameter[] parametrosInclui =
            {

                new SqlParameter("DataVenda", t.Data),
                new SqlParameter("ClienteID", t.Clienteid)


            };
                return parametrosInclui;
            }

            SqlParameter[] parametros =
            {

                new SqlParameter("ID", t.Id),
                new SqlParameter("DataVenda", t.Data),
                new SqlParameter("ClienteID", t.Clienteid),

            };

            return parametros;
        }

        public static int ProximoID()
        {
            string sql = "sp_RetornaIdPedido";
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                SqlCommand cmd = new SqlCommand(sql, cx);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static void Insere(VendaVO pedido)
        {



            using (var transacao = new System.Transactions.TransactionScope()) // início da transação
            {
                string sql = "SP_InserePedido ";


                Metodos.ExecutaProcedure(sql, CriaParametros(pedido));

                foreach (ItemVendaVO item in pedido.ItensDoPedido)
                {
                    item.Idvenda = pedido.Id;
                    ItemVendaDAO.InsereItemPedido(item);
                }

                transacao.Complete(); // efetua o commit. Se der uma exception neste código, ou ele não passar por esta linha, será considerado rollback
            }
        }



        protected static PadraoVO MontaVO(DataRow dr)
        {
            VendaVO t = new VendaVO();

            t.Id = Convert.ToInt32(dr["ID"]);
            t.Data = Convert.ToDateTime(dr["DataVenda"]);
            t.Clienteid = Convert.ToInt32(dr["ClienteID"]);
            return t;
        }
        public static PadraoVO Consulta(int id)
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                string sql = "SP_ProcuraPedidoVenda";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@id", id)
                };

                DataTable tabela = Metodos.ExecutaProcResultSet(sql, parametros);

                if (tabela.Rows.Count == 0)
                    return null;
                else
                    return MontaVO(tabela.Rows[0]);

            }
        }

    }


}
