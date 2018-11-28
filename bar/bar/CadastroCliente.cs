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
using Teste_trab.Enumeradores;

namespace Teste_trab
{
    public partial class CadastroCliente : frCadPadrao
    {
        public CadastroCliente()
        {
            cadastroDAO = new ClienteDAO();
            SugereProximoId = true;
            InitializeComponent();

        }
        protected override void PreencheTela(PadraoVO o)
        {
            try
            {
                if (o != null)
                {
                    ClienteVO cliente = o as ClienteVO;
                    txtId.Value = cliente.Id;
                    txtNome.Text = cliente.Nome;
                    txtCelular.Text = cliente.Celular;
                    txtCPF.Text = cliente.CPF;
                    txtCidadeID.Text = cliente.CidadeID.ToString();


                }
                else
                {
                    LimpaCampos(this);
                }
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            txtNome.Enabled = txtCidadeID.Enabled = txtCelular.Enabled = txtCPF.Enabled = btnpesquisacidade.Enabled = modo != EnumModoOperacao.Navegacao;
        }

        protected override PadraoVO PreencheObj()
        {
            ClienteVO cliente = new ClienteVO();
            cliente.Id = Convert.ToInt32(txtId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Celular = txtCelular.Text;
            cliente.CPF = txtCPF.Text;
            cliente.CidadeID = Convert.ToInt32(txtCidadeID.Text);
            return cliente;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (var tela = new PesquisaCliente())
            {

                tela.ShowDialog();
                if (tela.IdSelecionado != 0)
                {
                    var f = cadastroDAO.Consulta(tela.IdSelecionado);
                    PreencheTela(f);
                }
            }
        }
        
        

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnInclui_Click(object sender, EventArgs e)
        {

        }

        private void btnAltera_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var tela = new PesquisaCidade())
            {
                cadastroDAO = new CidadeDAO();

                tela.ShowDialog();
                txtCidadeID.Text = tela.IdSelecionado.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
