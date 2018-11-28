namespace Teste_trab
{
    partial class CadastroFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCidadeId = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(7, 85);
            this.txtId.Size = new System.Drawing.Size(46, 20);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisa.Location = new System.Drawing.Point(523, 12);
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(235, 12);
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGravar.Location = new System.Drawing.Point(178, 12);
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimo.Location = new System.Drawing.Point(466, 12);
            this.btnUltimo.UseVisualStyleBackColor = false;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.Control;
            this.btnProximo.Location = new System.Drawing.Point(409, 12);
            this.btnProximo.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.Location = new System.Drawing.Point(349, 12);
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimeiro.Location = new System.Drawing.Point(292, 12);
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.SystemColors.Control;
            this.btnExclui.Location = new System.Drawing.Point(121, 12);
            this.btnExclui.UseVisualStyleBackColor = false;
            // 
            // btnAltera
            // 
            this.btnAltera.BackColor = System.Drawing.SystemColors.Control;
            this.btnAltera.Location = new System.Drawing.Point(64, 12);
            this.btnAltera.UseVisualStyleBackColor = false;
            // 
            // btnInclui
            // 
            this.btnInclui.BackColor = System.Drawing.SystemColors.Control;
            this.btnInclui.Location = new System.Drawing.Point(7, 12);
            this.btnInclui.UseVisualStyleBackColor = false;
            this.btnInclui.Click += new System.EventHandler(this.btnInclui_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 84);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(127, 20);
            this.txtNome.TabIndex = 64;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(198, 83);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(2);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(112, 20);
            this.txtCNPJ.TabIndex = 65;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(314, 83);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Mask = "0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(76, 20);
            this.txtTelefone.TabIndex = 66;
            // 
            // txtCidadeId
            // 
            this.txtCidadeId.Location = new System.Drawing.Point(398, 84);
            this.txtCidadeId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidadeId.Name = "txtCidadeId";
            this.txtCidadeId.Size = new System.Drawing.Size(37, 20);
            this.txtCidadeId.TabIndex = 67;
            this.txtCidadeId.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nome Fantasia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Cidade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 21);
            this.button1.TabIndex = 72;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidadeId);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "CadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.CadastroFornecedor_Load);
            this.Controls.SetChildIndex(this.btnInclui, 0);
            this.Controls.SetChildIndex(this.btnAltera, 0);
            this.Controls.SetChildIndex(this.btnExclui, 0);
            this.Controls.SetChildIndex(this.btnPrimeiro, 0);
            this.Controls.SetChildIndex(this.btnAnterior, 0);
            this.Controls.SetChildIndex(this.btnProximo, 0);
            this.Controls.SetChildIndex(this.btnUltimo, 0);
            this.Controls.SetChildIndex(this.btnGravar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnPesquisa, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtCNPJ, 0);
            this.Controls.SetChildIndex(this.txtTelefone, 0);
            this.Controls.SetChildIndex(this.txtCidadeId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCidadeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}