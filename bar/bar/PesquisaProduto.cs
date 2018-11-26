using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_trab.DAO;
using Teste_trab.VO;

namespace Teste_trab
{
    public partial class PesquisaProduto : Form
    {
        public int IdSelecionado { get; private set; }
        public PesquisaProduto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<ProdutoVO> lista = (new ProdutoDAO()).ListarPorProduto(textBox1.Text.Trim());
            dataGridView1.DataSource = lista;
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ProdutoVO obj = dataGridView1.CurrentRow.DataBoundItem as ProdutoVO;
                IdSelecionado = obj.Id;
                Close();
            }
        }

        private void PesquisaProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
