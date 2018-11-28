namespace Teste_trab
{
    partial class frVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.cbformapagamento = new System.Windows.Forms.ComboBox();
            this.btncarrinho = new System.Windows.Forms.Button();
            this.btnfinalizarcompra = new System.Windows.Forms.Button();
            this.cbproduto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comanda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data da Venda";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Forma de Pagamento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(16, 30);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(56, 20);
            this.txtid.TabIndex = 6;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(84, 29);
            this.txtdata.Mask = "00/00/0000";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(76, 20);
            this.txtdata.TabIndex = 7;
            this.txtdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(177, 29);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(69, 20);
            this.txtcliente.TabIndex = 8;
            this.txtcliente.TextChanged += new System.EventHandler(this.txtcliente_TextChanged);
            this.txtcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcliente_KeyDown);
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(360, 30);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(59, 20);
            this.txtquantidade.TabIndex = 10;
            // 
            // cbformapagamento
            // 
            this.cbformapagamento.FormattingEnabled = true;
            this.cbformapagamento.Items.AddRange(new object[] {
            "Débito",
            "Credito"});
            this.cbformapagamento.Location = new System.Drawing.Point(443, 28);
            this.cbformapagamento.Name = "cbformapagamento";
            this.cbformapagamento.Size = new System.Drawing.Size(105, 21);
            this.cbformapagamento.TabIndex = 11;
            // 
            // btncarrinho
            // 
            this.btncarrinho.Location = new System.Drawing.Point(16, 103);
            this.btncarrinho.Name = "btncarrinho";
            this.btncarrinho.Size = new System.Drawing.Size(75, 39);
            this.btncarrinho.TabIndex = 12;
            this.btncarrinho.Text = "Adicionar ao carrinho";
            this.btncarrinho.UseVisualStyleBackColor = true;
            this.btncarrinho.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnfinalizarcompra
            // 
            this.btnfinalizarcompra.Location = new System.Drawing.Point(115, 103);
            this.btnfinalizarcompra.Name = "btnfinalizarcompra";
            this.btnfinalizarcompra.Size = new System.Drawing.Size(75, 39);
            this.btnfinalizarcompra.TabIndex = 13;
            this.btnfinalizarcompra.Text = "Finalizar Pedido";
            this.btnfinalizarcompra.UseVisualStyleBackColor = true;
            this.btnfinalizarcompra.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbproduto
            // 
            this.cbproduto.FormattingEnabled = true;
            this.cbproduto.Location = new System.Drawing.Point(266, 30);
            this.cbproduto.Name = "cbproduto";
            this.cbproduto.Size = new System.Drawing.Size(68, 21);
            this.cbproduto.TabIndex = 14;
            // 
            // frVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 217);
            this.Controls.Add(this.cbproduto);
            this.Controls.Add(this.btnfinalizarcompra);
            this.Controls.Add(this.btncarrinho);
            this.Controls.Add(this.cbformapagamento);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frVenda";
            this.Text = "frVenda";
            this.Load += new System.EventHandler(this.frVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frVenda_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frVenda_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.MaskedTextBox txtdata;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.ComboBox cbformapagamento;
        private System.Windows.Forms.Button btncarrinho;
        private System.Windows.Forms.Button btnfinalizarcompra;
        private System.Windows.Forms.ComboBox cbproduto;
    }
}