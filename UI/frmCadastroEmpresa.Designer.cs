namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroEmpresa
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CB_REGIAO = new System.Windows.Forms.ComboBox();
            this.LBL_REGIAO = new System.Windows.Forms.Label();
            this.LBL_ESTADOS = new System.Windows.Forms.Label();
            this.CB_ESTADOS = new System.Windows.Forms.ComboBox();
            this.LBL_MUNICIPIO = new System.Windows.Forms.Label();
            this.CB_MUNICIPIO = new System.Windows.Forms.ComboBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.LBL_MUNICIPIO);
            this.painel_campos.Controls.Add(this.CB_MUNICIPIO);
            this.painel_campos.Controls.Add(this.LBL_ESTADOS);
            this.painel_campos.Controls.Add(this.CB_ESTADOS);
            this.painel_campos.Controls.Add(this.LBL_REGIAO);
            this.painel_campos.Controls.Add(this.CB_REGIAO);
            this.painel_campos.Controls.Add(this.richTextBox1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(360, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 150);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // CB_REGIAO
            // 
            this.CB_REGIAO.FormattingEnabled = true;
            this.CB_REGIAO.Location = new System.Drawing.Point(77, 12);
            this.CB_REGIAO.Name = "CB_REGIAO";
            this.CB_REGIAO.Size = new System.Drawing.Size(187, 21);
            this.CB_REGIAO.TabIndex = 1;
            this.CB_REGIAO.SelectedIndexChanged += new System.EventHandler(this.CB_REGIAO_SelectedIndexChanged);
            // 
            // LBL_REGIAO
            // 
            this.LBL_REGIAO.AutoSize = true;
            this.LBL_REGIAO.Location = new System.Drawing.Point(9, 15);
            this.LBL_REGIAO.Name = "LBL_REGIAO";
            this.LBL_REGIAO.Size = new System.Drawing.Size(44, 13);
            this.LBL_REGIAO.TabIndex = 2;
            this.LBL_REGIAO.Text = "Região:";
            // 
            // LBL_ESTADOS
            // 
            this.LBL_ESTADOS.AutoSize = true;
            this.LBL_ESTADOS.Location = new System.Drawing.Point(9, 51);
            this.LBL_ESTADOS.Name = "LBL_ESTADOS";
            this.LBL_ESTADOS.Size = new System.Drawing.Size(48, 13);
            this.LBL_ESTADOS.TabIndex = 4;
            this.LBL_ESTADOS.Text = "Estados:";
            // 
            // CB_ESTADOS
            // 
            this.CB_ESTADOS.FormattingEnabled = true;
            this.CB_ESTADOS.Location = new System.Drawing.Point(77, 48);
            this.CB_ESTADOS.Name = "CB_ESTADOS";
            this.CB_ESTADOS.Size = new System.Drawing.Size(187, 21);
            this.CB_ESTADOS.TabIndex = 3;
            this.CB_ESTADOS.SelectedIndexChanged += new System.EventHandler(this.CB_ESTADOS_SelectedIndexChanged);
            // 
            // LBL_MUNICIPIO
            // 
            this.LBL_MUNICIPIO.AutoSize = true;
            this.LBL_MUNICIPIO.Location = new System.Drawing.Point(9, 88);
            this.LBL_MUNICIPIO.Name = "LBL_MUNICIPIO";
            this.LBL_MUNICIPIO.Size = new System.Drawing.Size(62, 13);
            this.LBL_MUNICIPIO.TabIndex = 6;
            this.LBL_MUNICIPIO.Text = "Municípios:";
            // 
            // CB_MUNICIPIO
            // 
            this.CB_MUNICIPIO.FormattingEnabled = true;
            this.CB_MUNICIPIO.Location = new System.Drawing.Point(77, 85);
            this.CB_MUNICIPIO.Name = "CB_MUNICIPIO";
            this.CB_MUNICIPIO.Size = new System.Drawing.Size(187, 21);
            this.CB_MUNICIPIO.TabIndex = 5;
            this.CB_MUNICIPIO.SelectedIndexChanged += new System.EventHandler(this.CB_MUNICIPIO_SelectedIndexChanged);
            // 
            // frmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(616, 237);
            this.Name = "frmCadastroEmpresa";
            this.Load += new System.EventHandler(this.frmCadastroEmpresa_Load);
            this.Controls.SetChildIndex(this.painel_campos, 0);
            this.Controls.SetChildIndex(this.Painel_botoes, 0);
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LBL_REGIAO;
        private System.Windows.Forms.ComboBox CB_REGIAO;
        private System.Windows.Forms.Label LBL_ESTADOS;
        private System.Windows.Forms.ComboBox CB_ESTADOS;
        private System.Windows.Forms.Label LBL_MUNICIPIO;
        private System.Windows.Forms.ComboBox CB_MUNICIPIO;
    }
}
