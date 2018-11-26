using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_trab.VO;
using Teste_trab.DAO;
using Teste_trab.Enumeradores;

namespace Teste_trab
{
    public partial class CadastroFornecedor : frCadPadrao
    {
        public CadastroFornecedor()
        {
            cadastroDAO = new FornecedorDAO();
            SugereProximoId = true;
            InitializeComponent();
        }
        protected override void PreencheTela(PadraoVO o)
        {
            if (o == null)
                return;

            FornecedorVO forn = o as FornecedorVO;
            txtId.Value = forn.Id;
            txtNome.Text = forn.Nome;
            txtCNPJ.Text = forn.Cnpj;
            txtTelefone.Text = forn.Telefone;
            txtCidadeId.Text = forn.CidadeID.ToString();
        }

        protected override PadraoVO PreencheObj()
        {
            int id = (int)txtId.Value;
            if (txtNome.Text.Trim().Length < 2)
                throw new Exception("Preencha Corretamente o Nome do fornecedor");
            if (txtCNPJ.Text[0]==' ')
                throw new Exception("Preencha Corretamente o CNPJ do fornecedor");
            if (txtTelefone.Text.Length < 8)
                throw new Exception("Preencha Corretamente o Telefone do fornecedor");
            if (txtCidadeId.Text.Length < 1)
                throw new Exception("Preencha Corretamente a Cidade do fornecedor");




            FornecedorVO forn = new FornecedorVO();
            forn.Id = id;
            forn.Nome = txtNome.Text.Trim();
            forn.Cnpj = txtCNPJ.Text;
            forn.Telefone = txtTelefone.Text;
            forn.CidadeID = Convert.ToInt32(txtCidadeId.Text);
            return forn;
        }

        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            txtNome.Enabled = txtCNPJ.Enabled = txtTelefone.Enabled = txtCidadeId.Enabled = modo != EnumModoOperacao.Navegacao;
        }
        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnInclui_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            /*PesquisaFornecedor tela = new PesquisaFornecedor();
            tela.ShowDialog();*/

            using (var tela = new PesquisaFornecedor())
            {

                tela.ShowDialog();
                if (tela.IdSelecionado != 0)
                {
                    var f = cadastroDAO.Consulta(tela.IdSelecionado);
                    PreencheTela(f);
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var tela = new PesquisaCidade())
            {

                tela.ShowDialog();
                txtCidadeId.Text = tela.IdSelecionado.ToString();
            }
        }
    }
}
