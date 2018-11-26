using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_trab.VO
{
    public class ProdutoVO:PadraoVO
    {
        string descricao;
        double valorCompra;
        double valorVenda;
        double volume;
        int fornecedorID;
        string imagem;

        public string Descricao { get => descricao; set => descricao = value; }
        public double ValorCompra { get => valorCompra; set => valorCompra = value; }
        public double ValorVenda { get => valorVenda; set => valorVenda = value; }
        public double Volume { get => volume; set => volume = value; }
        public int FornecedorID { get => fornecedorID; set => fornecedorID = value; }
        public string Imagem { get => imagem; set => imagem = value; }
    }
}
