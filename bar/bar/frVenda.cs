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
        int idvenda;
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


            try
            {
                ProdutoVO produto = cbproduto.SelectedValue as ProdutoVO;
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
                    item.Quantidade = 1;
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                VendaVO compra = new VendaVO();
                compra.Id = idvenda;
                compra.Data = DateTime.Now;
                compra.Clienteid = Convert.ToInt32(txtcliente.Text);
                compra.ItensDoPedido = carrinho.ToList();
                VendaDAO.Insere(compra);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
