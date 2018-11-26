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
    public partial class CadastroProduto : frCadPadrao
    {
        public CadastroProduto()
        {
            cadastroDAO = new ProdutoDAO();
            SugereProximoId = true;
            InitializeComponent();
        }
        protected override void PreencheTela(PadraoVO o)
        {
            if (o == null)
                return;

            ProdutoVO prod = o as ProdutoVO;
            txtId.Value = prod.Id;
            txtNome.Text = prod.Descricao;
            txtValorCompra.Text = prod.ValorCompra.ToString();
            txtValorVenda.Text = prod.ValorCompra.ToString();
            txtFornecedorId.Text = prod.FornecedorID.ToString();
            txtVolume.Text = prod.Volume.ToString();
            image.ImageLocation = prod.Imagem.ToString();
             

        }

        protected override PadraoVO PreencheObj()
        {
            int id = (int)txtId.Value;
            if (txtNome.Text.Trim().Length < 3)
                throw new Exception("Preencha o Nome do Produto Corretamente");
            if (Convert.ToInt32(txtValorCompra.Text) <= 0)
                throw new Exception("Preencha o Valor de Compra Corretamente");
            if (Convert.ToInt32(txtValorVenda.Text) <= 0)
                throw new Exception("Preencha o Valor de Venda Corretamente");
            if ((Convert.ToInt32(txtVolume.Text) <= 0))
                throw new Exception("Preencha o Volume Corretamente");
            if (txtFornecedorId.Text.Trim().Length == 0)
                throw new Exception("Fornecedor Deve Ser Informado");

            ProdutoVO prod = new ProdutoVO();
            prod.Id = id;
            prod.Descricao = txtNome.Text;
            prod.ValorCompra = Convert.ToDouble(txtValorCompra.Text);
            prod.ValorVenda = Convert.ToDouble(txtValorVenda.Text);
            prod.FornecedorID = Convert.ToInt32(txtFornecedorId.Text);
            prod.Volume = Convert.ToInt32(txtVolume.Text);
            prod.Imagem = image.ImageLocation;
            return prod;
        }

        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            txtNome.Enabled = txtValorCompra.Enabled = txtValorVenda.Enabled = txtFornecedorId.Enabled = txtVolume.Enabled = image.Enabled = btnimagem.Enabled = modo != EnumModoOperacao.Navegacao;
        }
        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            image.Image = null; //limpar o campo da imagem para cada inserção
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (var tela = new PesquisaProduto())
            {

                tela.ShowDialog();
                if (tela.IdSelecionado != 0)
                {
                    var f = cadastroDAO.Consulta(tela.IdSelecionado);
                    PreencheTela(f);
                }
            }
        }
        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void txtVolume_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblvolume_Click(object sender, EventArgs e)
        {

        }

        private void btnimagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (txtId == null)
                image.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var tela = new PesquisaFornecedor())
            {

                tela.ShowDialog();
                txtFornecedorId.Text = tela.IdSelecionado.ToString();
            }
        }
    }
}
