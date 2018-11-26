using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_trab
{
    public partial class frTelaPrincipal : Form
    {
        public frTelaPrincipal()
        {
            InitializeComponent();
        }


        private void frTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente tela = new CadastroCliente();
            tela.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor tela = new CadastroFornecedor();
            tela.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto tela = new CadastroProduto();
            tela.ShowDialog();
        }
    }
}
