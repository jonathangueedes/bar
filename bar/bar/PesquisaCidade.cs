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
    public partial class PesquisaCidade : Form
    {
        public int IdSelecionado = 0;

        public PesquisaCidade()
        {
            InitializeComponent();
            gv.AllowUserToAddRows = false;
            gv.AllowUserToDeleteRows = false;
            gv.AllowUserToResizeRows = false;
            gv.MultiSelect = false;
            gv.ReadOnly = true;
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            List<CidadeVO> lista = (new CidadeDAO()).ListarPorNome(txtNome.Text.Trim());
            gv.DataSource = lista;
            gv.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gv.CurrentRow != null)
            {
                CidadeVO obj = gv.CurrentRow.DataBoundItem as CidadeVO;
                IdSelecionado = obj.Id;
                Close();
            }
        }

        private void PesquisaCidade_Load(object sender, EventArgs e)
        {

        }
    }
}
