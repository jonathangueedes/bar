using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_trab.VO;

namespace Teste_trab.DAO
{
    class ItemVendaDAO
    {

        protected static SqlParameter[] CriaParametros(ItemVendaVO o)
        {
            ItemVendaVO t = (o as ItemVendaVO);


            SqlParameter[] parametrosInclui =
        {

                new SqlParameter("IDVENDA", t.Idvenda),
                new SqlParameter("IDPRODUTO", t.Idproduto),
                new SqlParameter("Quantidade",t.Quantidade)


            };
            return parametrosInclui;
        }
        public static void InsereItemPedido(ItemVendaVO item)
        {
            string sql = "sp_InsereItemVenda";
            Metodos.ExecutaProcedure(sql, CriaParametros(item));
        }

        protected static ItemVendaVO MontaVO(DataRow dr)
        {
            ItemVendaVO t = new ItemVendaVO();

            t.Idproduto = Convert.ToInt32(dr["IDPRODUTO"]);
            t.Idvenda = Convert.ToInt32(dr["IDVENDA"]);
            t.Quantidade = Convert.ToInt32(dr["Quantidade"]);
            return t;
        }

    }
}
