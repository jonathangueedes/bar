namespace Teste_trab
{
    partial class CadastroProduto
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
            this.txtFornecedorId = new System.Windows.Forms.MaskedTextBox();
            this.txtValorCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.MaskedTextBox();
            this.txtVolume = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblvolume = new System.Windows.Forms.Label();
            this.btnimagem = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 84);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisa.Location = new System.Drawing.Point(528, 14);
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(240, 14);
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGravar.Location = new System.Drawing.Point(183, 14);
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimo.Location = new System.Drawing.Point(471, 14);
            this.btnUltimo.UseVisualStyleBackColor = false;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.Control;
            this.btnProximo.Location = new System.Drawing.Point(414, 14);
            this.btnProximo.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.Location = new System.Drawing.Point(354, 14);
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimeiro.Location = new System.Drawing.Point(297, 14);
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.SystemColors.Control;
            this.btnExclui.Location = new System.Drawing.Point(126, 14);
            this.btnExclui.UseVisualStyleBackColor = false;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.BackColor = System.Drawing.SystemColors.Control;
            this.btnAltera.Location = new System.Drawing.Point(69, 14);
            this.btnAltera.UseVisualStyleBackColor = false;
            // 
            // btnInclui
            // 
            this.btnInclui.BackColor = System.Drawing.SystemColors.Control;
            this.btnInclui.Location = new System.Drawing.Point(12, 14);
            this.btnInclui.UseVisualStyleBackColor = false;
            this.btnInclui.Click += new System.EventHandler(this.btnInclui_Click);
            // 
            // txtFornecedorId
            // 
            this.txtFornecedorId.Location = new System.Drawing.Point(495, 84);
            this.txtFornecedorId.Margin = new System.Windows.Forms.Padding(2);
            this.txtFornecedorId.Name = "txtFornecedorId";
            this.txtFornecedorId.Size = new System.Drawing.Size(58, 20);
            this.txtFornecedorId.TabIndex = 71;
            this.txtFornecedorId.ValidatingType = typeof(int);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(215, 83);
            this.txtValorCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(76, 20);
            this.txtValorCompra.TabIndex = 69;
            this.txtValorCompra.ValidatingType = typeof(int);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(126, 84);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(76, 20);
            this.txtNome.TabIndex = 68;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(313, 83);
            this.txtValorVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(76, 20);
            this.txtValorVenda.TabIndex = 72;
            this.txtValorVenda.ValidatingType = typeof(int);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(405, 83);
            this.txtVolume.Margin = new System.Windows.Forms.Padding(2);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(76, 20);
            this.txtVolume.TabIndex = 73;
            this.txtVolume.ValidatingType = typeof(int);
            this.txtVolume.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtVolume_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Valor Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Valor Revenda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Fornecedor";
            // 
            // lblvolume
            // 
            this.lblvolume.AutoSize = true;
            this.lblvolume.Location = new System.Drawing.Point(402, 68);
            this.lblvolume.Name = "lblvolume";
            this.lblvolume.Size = new System.Drawing.Size(42, 13);
            this.lblvolume.TabIndex = 79;
            this.lblvolume.Text = "Volume";
            this.lblvolume.Click += new System.EventHandler(this.lblvolume_Click);
            // 
            // btnimagem
            // 
            this.btnimagem.BackgroundImage = global::Teste_trab.Properties.Resources.no_image_icon_13;
            this.btnimagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnimagem.Location = new System.Drawing.Point(104, 371);
            this.btnimagem.Name = "btnimagem";
            this.btnimagem.Size = new System.Drawing.Size(39, 30);
            this.btnimagem.TabIndex = 80;
            this.btnimagem.UseVisualStyleBackColor = true;
            this.btnimagem.Click += new System.EventHandler(this.btnimagem_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(6, 19);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(216, 215);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 81;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.image);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 285);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 83;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnimagem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblvolume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtFornecedorId);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "CadastroProduto";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
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
            this.Controls.SetChildIndex(this.txtValorCompra, 0);
            this.Controls.SetChildIndex(this.txtFornecedorId, 0);
            this.Controls.SetChildIndex(this.txtValorVenda, 0);
            this.Controls.SetChildIndex(this.txtVolume, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblvolume, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnimagem, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtFornecedorId;
        private System.Windows.Forms.MaskedTextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtValorVenda;
        private System.Windows.Forms.MaskedTextBox txtVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblvolume;
        private System.Windows.Forms.Button btnimagem;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}