using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_trab.VO
{
    public class VendaVO : PadraoVO
    {

        DateTime data;
        int clienteid;

        public DateTime Data { get => data; set => data = value; }
        public int Clienteid { get => clienteid; set => clienteid = value; }
        public List<ItemVendaVO> ItensDoPedido { get; set; } = new List<ItemVendaVO>();



    }
}
