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
    public partial class frVenda : Form
    {

        BindingList<ItemVendaVO> carrinho = new BindingList<ItemVendaVO>();
        ProdutoDAO p;
        VendaDAO c;
        public int idvenda;
        
        public frVenda()
        {
            p = new ProdutoDAO();
            c = new VendaDAO();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbformapagamento.Enabled = false;

            try
            {
                //cbproduto.SelectedValue = txtproduto.Text;
                int idprod = Convert.ToInt32(cbproduto.SelectedValue);
                ProdutoVO produto = p.Consulta(idprod) as ProdutoVO;
                ItemVendaVO produtoPesquisado = null;
                foreach (ItemVendaVO item in carrinho)
                if (item.Idproduto == produto.Id)
                {
                    produtoPesquisado = item;
                    break;
                }


                if (produtoPesquisado != null)
                    produtoPesquisado.Quantidade++; // apenas altera a quantidade
                else
                {
                    ItemVendaVO item = new ItemVendaVO();
                    item.Idproduto = produto.Id;
                    item.Idvenda = idvenda;
                    item.Quantidade = Convert.ToInt32(txtquantidade.Text);
                    carrinho.Add(item);
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void frVenda_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtdata.Text = DateTime.Now.ToString();
            txtid.Text = VendaDAO.ProximoID().ToString();
            int idvendaform = Convert.ToInt32(txtid.Text);
            idvenda = idvendaform;

            List<ProdutoVO> produtos = new List<ProdutoVO>();
            produtos = p.ListarPorProduto("");
          
            cbproduto.DataSource = produtos;
            cbproduto.DisplayMember = "Descricao";
            cbproduto.ValueMember = "Id";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                VendaVO venda = new VendaVO();
                venda.Id = idvenda;
                venda.Data = Convert.ToDateTime(txtdata.Text);
                venda.Clienteid = Convert.ToInt32(txtcliente.Text);
                venda.ItensDoPedido = carrinho.ToList();
                venda.Formapagamento = cbformapagamento.SelectedItem.ToString();
                VendaDAO.Insere(venda);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_pesquisa(object sender, KeyEventArgs e)
        {
           
        }



        private void txtcliente_TextChanged(object sender, EventArgs e)
        {


            
        }

        private void frVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frVenda_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtcliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                var frm = new PesquisaCliente();
                frm.ShowDialog();
                txtcliente.Text = frm.IdSelecionado.ToString();
            }
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
