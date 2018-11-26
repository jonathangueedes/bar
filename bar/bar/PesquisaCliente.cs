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
    public partial class PesquisaCliente : Form
    {
        public int IdSelecionado { get; private set; }
        public PesquisaCliente()
        {
            InitializeComponent();
            gv.AllowUserToAddRows = false;
            gv.AllowUserToDeleteRows = false;
            gv.AllowUserToResizeRows = false;
            gv.MultiSelect = false;
            gv.ReadOnly = true;
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gv.CurrentRow != null)
            {
                ClienteVO obj = gv.CurrentRow.DataBoundItem as ClienteVO;
                IdSelecionado = obj.Id;
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<ClienteVO> lista = (new ClienteDAO()).ListarPorNome(txtNome.Text.Trim());
            gv.DataSource = lista;
            gv.ReadOnly = true;
        }

       

        private void PesquisaCliente_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
