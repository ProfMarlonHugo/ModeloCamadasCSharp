namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroPessoa
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
            this.TXTCPF = new System.Windows.Forms.TextBox();
            this.TXTNome = new System.Windows.Forms.TextBox();
            this.DTPNascimento = new System.Windows.Forms.DateTimePicker();
            this.TXTId = new System.Windows.Forms.TextBox();
            this.TXTEmail = new System.Windows.Forms.TextBox();
            this.LBLCodigo = new System.Windows.Forms.Label();
            this.LBLNome = new System.Windows.Forms.Label();
            this.LBLDtNascimento = new System.Windows.Forms.Label();
            this.LBLSexo = new System.Windows.Forms.Label();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.CB_Sexo = new System.Windows.Forms.ComboBox();
            this.LBLCpf = new System.Windows.Forms.Label();
            this.PN_img = new System.Windows.Forms.Panel();
            this.PB_img = new System.Windows.Forms.PictureBox();
            this.lbl_img = new System.Windows.Forms.Label();
            this.btn_buscar_img = new System.Windows.Forms.Button();
            this.btn_remover_img = new System.Windows.Forms.Button();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.PN_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).BeginInit();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.TXTCPF);
            this.painel_campos.Controls.Add(this.TXTNome);
            this.painel_campos.Controls.Add(this.DTPNascimento);
            this.painel_campos.Controls.Add(this.TXTId);
            this.painel_campos.Controls.Add(this.TXTEmail);
            this.painel_campos.Controls.Add(this.LBLCodigo);
            this.painel_campos.Controls.Add(this.LBLNome);
            this.painel_campos.Controls.Add(this.LBLDtNascimento);
            this.painel_campos.Controls.Add(this.LBLSexo);
            this.painel_campos.Controls.Add(this.LBLEmail);
            this.painel_campos.Controls.Add(this.CB_Sexo);
            this.painel_campos.Controls.Add(this.LBLCpf);
            this.painel_campos.Size = new System.Drawing.Size(363, 156);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Size = new System.Drawing.Size(489, 54);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // TXTCPF
            // 
            this.TXTCPF.Location = new System.Drawing.Point(242, 95);
            this.TXTCPF.MaxLength = 14;
            this.TXTCPF.Name = "TXTCPF";
            this.TXTCPF.Size = new System.Drawing.Size(105, 20);
            this.TXTCPF.TabIndex = 20;
            this.TXTCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCPF_KeyPress);
            // 
            // TXTNome
            // 
            this.TXTNome.Location = new System.Drawing.Point(103, 43);
            this.TXTNome.MaxLength = 100;
            this.TXTNome.Name = "TXTNome";
            this.TXTNome.Size = new System.Drawing.Size(244, 20);
            this.TXTNome.TabIndex = 17;
            // 
            // DTPNascimento
            // 
            this.DTPNascimento.Location = new System.Drawing.Point(103, 69);
            this.DTPNascimento.Name = "DTPNascimento";
            this.DTPNascimento.Size = new System.Drawing.Size(244, 20);
            this.DTPNascimento.TabIndex = 18;
            // 
            // TXTId
            // 
            this.TXTId.Enabled = false;
            this.TXTId.Location = new System.Drawing.Point(103, 18);
            this.TXTId.Name = "TXTId";
            this.TXTId.Size = new System.Drawing.Size(46, 20);
            this.TXTId.TabIndex = 28;
            // 
            // TXTEmail
            // 
            this.TXTEmail.Location = new System.Drawing.Point(103, 122);
            this.TXTEmail.MaxLength = 50;
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(244, 20);
            this.TXTEmail.TabIndex = 19;
            // 
            // LBLCodigo
            // 
            this.LBLCodigo.AutoSize = true;
            this.LBLCodigo.Location = new System.Drawing.Point(20, 21);
            this.LBLCodigo.Name = "LBLCodigo";
            this.LBLCodigo.Size = new System.Drawing.Size(40, 13);
            this.LBLCodigo.TabIndex = 27;
            this.LBLCodigo.Text = "Código";
            // 
            // LBLNome
            // 
            this.LBLNome.AutoSize = true;
            this.LBLNome.Location = new System.Drawing.Point(20, 46);
            this.LBLNome.Name = "LBLNome";
            this.LBLNome.Size = new System.Drawing.Size(35, 13);
            this.LBLNome.TabIndex = 21;
            this.LBLNome.Text = "Nome";
            // 
            // LBLDtNascimento
            // 
            this.LBLDtNascimento.AutoSize = true;
            this.LBLDtNascimento.Location = new System.Drawing.Point(20, 75);
            this.LBLDtNascimento.Name = "LBLDtNascimento";
            this.LBLDtNascimento.Size = new System.Drawing.Size(77, 13);
            this.LBLDtNascimento.TabIndex = 22;
            this.LBLDtNascimento.Text = "Dt.Nascimento";
            // 
            // LBLSexo
            // 
            this.LBLSexo.AutoSize = true;
            this.LBLSexo.Location = new System.Drawing.Point(20, 98);
            this.LBLSexo.Name = "LBLSexo";
            this.LBLSexo.Size = new System.Drawing.Size(31, 13);
            this.LBLSexo.TabIndex = 23;
            this.LBLSexo.Text = "Sexo";
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Location = new System.Drawing.Point(20, 125);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(35, 13);
            this.LBLEmail.TabIndex = 24;
            this.LBLEmail.Text = "E-mail";
            // 
            // CB_Sexo
            // 
            this.CB_Sexo.FormattingEnabled = true;
            this.CB_Sexo.Location = new System.Drawing.Point(103, 95);
            this.CB_Sexo.Name = "CB_Sexo";
            this.CB_Sexo.Size = new System.Drawing.Size(100, 21);
            this.CB_Sexo.TabIndex = 26;
            // 
            // LBLCpf
            // 
            this.LBLCpf.AutoSize = true;
            this.LBLCpf.Location = new System.Drawing.Point(209, 98);
            this.LBLCpf.Name = "LBLCpf";
            this.LBLCpf.Size = new System.Drawing.Size(27, 13);
            this.LBLCpf.TabIndex = 25;
            this.LBLCpf.Text = "CPF";
            // 
            // PN_img
            // 
            this.PN_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_img.Controls.Add(this.PB_img);
            this.PN_img.Location = new System.Drawing.Point(372, 30);
            this.PN_img.Name = "PN_img";
            this.PN_img.Size = new System.Drawing.Size(121, 109);
            this.PN_img.TabIndex = 2;
            // 
            // PB_img
            // 
            this.PB_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_img.Location = new System.Drawing.Point(0, 0);
            this.PB_img.Name = "PB_img";
            this.PB_img.Size = new System.Drawing.Size(119, 107);
            this.PB_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_img.TabIndex = 0;
            this.PB_img.TabStop = false;
            // 
            // lbl_img
            // 
            this.lbl_img.AutoSize = true;
            this.lbl_img.Location = new System.Drawing.Point(372, 14);
            this.lbl_img.Name = "lbl_img";
            this.lbl_img.Size = new System.Drawing.Size(44, 13);
            this.lbl_img.TabIndex = 28;
            this.lbl_img.Text = "Imagem";
            // 
            // btn_buscar_img
            // 
            this.btn_buscar_img.Location = new System.Drawing.Point(372, 144);
            this.btn_buscar_img.Name = "btn_buscar_img";
            this.btn_buscar_img.Size = new System.Drawing.Size(54, 23);
            this.btn_buscar_img.TabIndex = 29;
            this.btn_buscar_img.Text = "Buscar";
            this.btn_buscar_img.UseVisualStyleBackColor = true;
            this.btn_buscar_img.Click += new System.EventHandler(this.btn_buscar_img_Click);
            // 
            // btn_remover_img
            // 
            this.btn_remover_img.Location = new System.Drawing.Point(432, 144);
            this.btn_remover_img.Name = "btn_remover_img";
            this.btn_remover_img.Size = new System.Drawing.Size(61, 23);
            this.btn_remover_img.TabIndex = 30;
            this.btn_remover_img.Text = "Remover";
            this.btn_remover_img.UseVisualStyleBackColor = true;
            this.btn_remover_img.Click += new System.EventHandler(this.btn_remover_img_Click);
            // 
            // frmCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(499, 234);
            this.Controls.Add(this.btn_remover_img);
            this.Controls.Add(this.btn_buscar_img);
            this.Controls.Add(this.lbl_img);
            this.Controls.Add(this.PN_img);
            this.Name = "frmCadastroPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de passoa";
            this.Load += new System.EventHandler(this.frmCadastroPessoa_Load);
            this.Controls.SetChildIndex(this.PN_img, 0);
            this.Controls.SetChildIndex(this.lbl_img, 0);
            this.Controls.SetChildIndex(this.btn_buscar_img, 0);
            this.Controls.SetChildIndex(this.btn_remover_img, 0);
            this.Controls.SetChildIndex(this.painel_campos, 0);
            this.Controls.SetChildIndex(this.Painel_botoes, 0);
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.PN_img.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTCPF;
        private System.Windows.Forms.TextBox TXTNome;
        private System.Windows.Forms.DateTimePicker DTPNascimento;
        private System.Windows.Forms.TextBox TXTId;
        private System.Windows.Forms.TextBox TXTEmail;
        private System.Windows.Forms.Label LBLCodigo;
        private System.Windows.Forms.Label LBLNome;
        private System.Windows.Forms.Label LBLDtNascimento;
        private System.Windows.Forms.Label LBLSexo;
        private System.Windows.Forms.Label LBLEmail;
        private System.Windows.Forms.ComboBox CB_Sexo;
        private System.Windows.Forms.Label LBLCpf;
        private System.Windows.Forms.Panel PN_img;
        private System.Windows.Forms.PictureBox PB_img;
        private System.Windows.Forms.Label lbl_img;
        private System.Windows.Forms.Button btn_buscar_img;
        private System.Windows.Forms.Button btn_remover_img;
    }
}
