using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_trab.VO
{
    public class ClienteVO:PadraoVO
    {
        private string nome;
        private string cpf;
        private string celular;
        private int cidadeID;

        public string Nome { get => nome; set => nome = value; }
        public string CPF { get => cpf; set => cpf = value; }
        public string Celular { get => celular; set => celular = value; }
        public int CidadeID { get => cidadeID; set => cidadeID = value; }
    }
}
