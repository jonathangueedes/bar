using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_trab.VO
{
    public class ItemVendaVO
    {

        int IDVENDA;
        int IDPRODUTO;
        int QUANTIDADE;
        public int Idvenda { get => IDVENDA; set => IDVENDA = value; }
        public int Idproduto { get => IDPRODUTO; set => IDPRODUTO = value; }
        public int Quantidade { get => QUANTIDADE; set => QUANTIDADE = value; }


    }
}
