using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_trab.VO
{
    public class FornecedorVO:PadraoVO
    {
        
        string nome;
        string cnpj;
        string telefone;
        int cidadeID;

       
        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int CidadeID { get => cidadeID; set => cidadeID = value; }
    }
}
