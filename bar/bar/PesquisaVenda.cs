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

namespace Teste_trab
{
    public partial class PesquisaVenda : Form
    {
     
        public PesquisaVenda()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendaDAO.ListaProdutosVenda(Convert.ToInt32(textBox1.Text));
        }
    }
}
