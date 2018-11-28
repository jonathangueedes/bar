namespace Teste_trab
{
    partial class frCadPadrao
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
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnInclui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 105);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(90, 20);
            this.txtId.TabIndex = 63;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = global::Teste_trab.Properties.Resources.Azure_Search;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisa.Location = new System.Drawing.Point(528, 35);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(56, 43);
            this.btnPesquisa.TabIndex = 62;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Teste_trab.Properties.Resources.ASX_Cancel_blue_16x;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Location = new System.Drawing.Point(240, 35);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 43);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImage = global::Teste_trab.Properties.Resources.Checkmark_success;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravar.Location = new System.Drawing.Point(183, 35);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(51, 43);
            this.btnGravar.TabIndex = 60;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackgroundImage = global::Teste_trab.Properties.Resources.ultimo;
            this.btnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimo.Location = new System.Drawing.Point(471, 35);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(51, 43);
            this.btnUltimo.TabIndex = 59;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackgroundImage = global::Teste_trab.Properties.Resources.proximo;
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProximo.Location = new System.Drawing.Point(414, 35);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(51, 43);
            this.btnProximo.TabIndex = 58;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackgroundImage = global::Teste_trab.Properties.Resources.anterior1;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAnterior.Location = new System.Drawing.Point(354, 35);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(51, 43);
            this.btnAnterior.TabIndex = 57;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackgroundImage = global::Teste_trab.Properties.Resources.primeiro;
            this.btnPrimeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimeiro.Location = new System.Drawing.Point(297, 35);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(51, 43);
            this.btnPrimeiro.TabIndex = 56;
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.BackgroundImage = global::Teste_trab.Properties.Resources.delete_icon_png_18;
            this.btnExclui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExclui.Location = new System.Drawing.Point(126, 35);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(51, 43);
            this.btnExclui.TabIndex = 55;
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.BackgroundImage = global::Teste_trab.Properties.Resources.@__17_512;
            this.btnAltera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAltera.Location = new System.Drawing.Point(69, 35);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(51, 43);
            this.btnAltera.TabIndex = 54;
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnInclui
            // 
            this.btnInclui.BackgroundImage = global::Teste_trab.Properties.Resources.add_window_image_tile_create_blue_round_512;
            this.btnInclui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInclui.Location = new System.Drawing.Point(12, 35);
            this.btnInclui.Name = "btnInclui";
            this.btnInclui.Size = new System.Drawing.Size(51, 43);
            this.btnInclui.TabIndex = 53;
            this.btnInclui.UseVisualStyleBackColor = true;
            this.btnInclui.Click += new System.EventHandler(this.btnInclui_Click);
            // 
            // frCadPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 295);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.btnAltera);
            this.Controls.Add(this.btnInclui);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frCadPadrao";
            this.Text = "frCadPadrao";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.NumericUpDown txtId;
        protected System.Windows.Forms.Button btnPesquisa;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnGravar;
        protected System.Windows.Forms.Button btnUltimo;
        protected System.Windows.Forms.Button btnProximo;
        protected System.Windows.Forms.Button btnAnterior;
        protected System.Windows.Forms.Button btnPrimeiro;
        protected System.Windows.Forms.Button btnExclui;
        protected System.Windows.Forms.Button btnAltera;
        protected System.Windows.Forms.Button btnInclui;
    }
}