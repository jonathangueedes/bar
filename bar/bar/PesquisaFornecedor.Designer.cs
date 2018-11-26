namespace Teste_trab
{
    partial class PesquisaFornecedor
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
            this.button1 = new System.Windows.Forms.Button();
            this.gv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(2, 85);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(482, 219);
            this.gv.TabIndex = 6;
            this.gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o Fornecedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(2, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(482, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "PesquisaFornecedor";
            this.Text = "Pesquisa Fornecedor";
            this.Load += new System.EventHandler(this.PesquisaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
    }
}