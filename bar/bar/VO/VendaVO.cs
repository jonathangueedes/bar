using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_trab.VO
{
    public class VendaVO : PadraoVO
    {

        DateTime data;
        int clienteid;
        String formapagamento;

        public DateTime Data { get => data; set => data = value; }
        public int Clienteid { get => clienteid; set => clienteid = value; }

        public string Formapagamento { get => formapagamento; set => formapagamento = value; }
        public List<ItemVendaVO> ItensDoPedido { get; set; } = new List<ItemVendaVO>();



    }
}
