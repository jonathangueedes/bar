namespace Teste_trab
{
    partial class CadastroCliente
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
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCidadeID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnpesquisacidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 87);
            this.txtId.Size = new System.Drawing.Size(40, 20);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisa.Location = new System.Drawing.Point(528, 17);
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(240, 17);
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGravar.Location = new System.Drawing.Point(183, 17);
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimo.Location = new System.Drawing.Point(471, 17);
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.Control;
            this.btnProximo.Location = new System.Drawing.Point(414, 17);
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.Location = new System.Drawing.Point(354, 17);
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimeiro.Location = new System.Drawing.Point(297, 17);
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.SystemColors.Control;
            this.btnExclui.Location = new System.Drawing.Point(126, 17);
            this.btnExclui.UseVisualStyleBackColor = false;
            // 
            // btnAltera
            // 
            this.btnAltera.BackColor = System.Drawing.SystemColors.Control;
            this.btnAltera.Location = new System.Drawing.Point(69, 17);
            this.btnAltera.UseVisualStyleBackColor = false;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnInclui
            // 
            this.btnInclui.BackColor = System.Drawing.SystemColors.Control;
            this.btnInclui.Location = new System.Drawing.Point(12, 17);
            this.btnInclui.UseVisualStyleBackColor = false;
            this.btnInclui.Click += new System.EventHandler(this.btnInclui_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 87);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(76, 20);
            this.txtNome.TabIndex = 64;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(155, 89);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.txtCelular.Mask = "00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(76, 20);
            this.txtCelular.TabIndex = 65;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(248, 89);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(90, 20);
            this.txtCPF.TabIndex = 66;
            // 
            // txtCidadeID
            // 
            this.txtCidadeID.Location = new System.Drawing.Point(353, 89);
            this.txtCidadeID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidadeID.Name = "txtCidadeID";
            this.txtCidadeID.Size = new System.Drawing.Size(38, 20);
            this.txtCidadeID.TabIndex = 67;
            this.txtCidadeID.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "CIdade";
            // 
            // btnpesquisacidade
            // 
            this.btnpesquisacidade.Location = new System.Drawing.Point(396, 89);
            this.btnpesquisacidade.Name = "btnpesquisacidade";
            this.btnpesquisacidade.Size = new System.Drawing.Size(30, 20);
            this.btnpesquisacidade.TabIndex = 73;
            this.btnpesquisacidade.Text = "...";
            this.btnpesquisacidade.UseVisualStyleBackColor = true;
            this.btnpesquisacidade.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 339);
            this.Controls.Add(this.btnpesquisacidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidadeID);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "CadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
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
            this.Controls.SetChildIndex(this.txtCidadeID, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnpesquisacidade, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtCidadeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnpesquisacidade;
    }
}

