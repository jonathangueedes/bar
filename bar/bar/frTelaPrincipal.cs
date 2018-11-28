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

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frVenda tela = new frVenda();
            tela.ShowDialog();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre tela = new Sobre();
            tela.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisaVenda pv = new PesquisaVenda();
            pv.ShowDialog();
        }
    }
}
