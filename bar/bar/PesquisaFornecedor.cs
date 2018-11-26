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
    public partial class PesquisaFornecedor : Form
    {
        public int IdSelecionado = 0;
        public PesquisaFornecedor()
        {
            InitializeComponent();
            gv.AllowUserToAddRows = false;
            gv.AllowUserToDeleteRows = false;
            gv.AllowUserToResizeRows = false;
            gv.MultiSelect = false;
            gv.ReadOnly = true;
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<FornecedorVO> lista = (new FornecedorDAO()).ListarPorFornecedor(txtNome.Text.Trim());
            gv.DataSource = lista;
            gv.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gv.CurrentRow != null)
            {
                FornecedorVO obj = gv.CurrentRow.DataBoundItem as FornecedorVO;
                IdSelecionado = obj.Id;
                Close();
            }
        }

        private void PesquisaFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
