﻿using System;
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
using System.Data.SqlClient;

namespace Teste_trab
{
    public partial class frCadPadrao : Form
    {

        protected PadraoDAO cadastroDAO;
        public bool SugereProximoId { get; set; } = false;
        public frCadPadrao()
        {

            if (!EstaEmModoDev()) // modo de desenvolvimento
            {
            }
            InitializeComponent();

        }

        protected virtual void PreencheTela(PadraoVO o)
        {
            //preencher nos filhos
        }

        protected void TrataErro(Exception erro)
        {
            if (erro is FormatException)
            {
                Metodos.Mensagem("Campo numérico inválido!", TipoMensagemEnum.erro);
            }
            else if (erro is SqlException)
            {
                Metodos.Mensagem("Ocorreu um erro no banco de dados.", TipoMensagemEnum.erro);
            }
            else if (erro is Exception)
            {
                Metodos.Mensagem(erro.Message, TipoMensagemEnum.erro);
            }
        }

        protected bool EstaEmModoDev()
        {
            return (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
        }

        private void AlteraParaModo(EnumModoOperacao modo)
        {
            btnInclui.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnAltera.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnExclui.Enabled = (modo == EnumModoOperacao.Navegacao) &&
                                 txtId.Text.Length > 0;

            btnPrimeiro.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnAnterior.Enabled = (modo == EnumModoOperacao.Navegacao) && txtId.Value > 0;
            btnProximo.Enabled = (modo == EnumModoOperacao.Navegacao) && txtId.Value > 0;
            btnUltimo.Enabled = (modo == EnumModoOperacao.Navegacao);

            btnGravar.Enabled = (modo != EnumModoOperacao.Navegacao);
            btnCancelar.Enabled = (modo != EnumModoOperacao.Navegacao);
            btnPesquisa.Enabled = (modo == EnumModoOperacao.Navegacao);

            if (modo == EnumModoOperacao.Inclusao)
            {
                //txtId.Enabled = true; usando identity nao pode estar habilitado
                LimpaCampos(this);
                txtId.Focus();
            }
            else
                txtId.Enabled = false;


            ControlaCamposTela(modo); // propositalmene no final para que se possa alterar alguns dos comportamentos acima nos descendentes
        }

        protected virtual void ControlaCamposTela(EnumModoOperacao modo)
        {
            // deve ser sobrescrito
        }

        protected void LimpaCampos(Control objeto)
        {
            if (objeto is TextBox ||
                objeto is MaskedTextBox)
                objeto.Text = "";
            else if (objeto is NumericUpDown)
                (objeto as NumericUpDown).Value = 0;
            else
            {
                foreach (Control o in objeto.Controls)
                    LimpaCampos(o);
            }
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            if (!EstaEmModoDev()) // modo de desenvolvimento
            {
                btnPrimeiro.PerformClick();
                AlteraParaModo(EnumModoOperacao.Navegacao);
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Alteracao);
            txtId.Enabled = true;
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Inclusao);
            if (SugereProximoId)
                txtId.Value = cadastroDAO.ProximoId();
        }





        protected virtual PadraoVO PreencheObj()
        {
            return null; // é necessário ter algo .. não é void!  Programar nos descendentes
        }



        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (Metodos.ValidaInt(txtId.Text) == false)
            {
                Metodos.Mensagem("Digite apenas números no campo ID.",
                    TipoMensagemEnum.alerta);
                return;
            }

            if (!Metodos.Mensagem("Tem Certeza que Deseja Excluir?", TipoMensagemEnum.pergunta))
                return;

            try
            {
                cadastroDAO.Excluir(Convert.ToInt32(txtId.Text));
                btnPrimeiro.PerformClick();
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO obj = PreencheObj();

                if (txtId.Enabled == false)
                    cadastroDAO.Inserir(obj);
                else
                    cadastroDAO.Alterar(obj);

                AlteraParaModo(EnumModoOperacao.Navegacao);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtId.Enabled)
                PreencheTela(cadastroDAO.Primeiro());
            else
                PreencheTela(cadastroDAO.Consulta(Convert.ToInt32(txtId.Text)));

            AlteraParaModo(EnumModoOperacao.Navegacao);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = cadastroDAO.Anterior(Convert.ToInt32(txtId.Text));
                if (o != null)
                    PreencheTela(o);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = cadastroDAO.Proximo(Convert.ToInt32(txtId.Text));
                if (o != null)
                    PreencheTela(o);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = cadastroDAO.Ultimo();
                PreencheTela(o);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {

            try
            {
                PadraoVO o = cadastroDAO.Primeiro();
                PreencheTela(o);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

       
    }
    

   
}

