using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_trab.VO
{
    public class CidadeVO:PadraoVO
    {
        private string cidade;
        private int ufid;

        public string Cidade { get => cidade; set => cidade = value; }

        public int UfID { get => ufid; set => ufid = value; }

    }
}
