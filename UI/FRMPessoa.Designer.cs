namespace PadraoDeProjetoEmCamadas
{
    partial class FRMPessoa
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
            this.TXTNome = new System.Windows.Forms.TextBox();
            this.DTPNascimento = new System.Windows.Forms.DateTimePicker();
            this.TXTEmail = new System.Windows.Forms.TextBox();
            this.TXTCPF = new System.Windows.Forms.TextBox();
            this.LBLNome = new System.Windows.Forms.Label();
            this.LBLDtNascimento = new System.Windows.Forms.Label();
            this.LBLSexo = new System.Windows.Forms.Label();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.LBLCpf = new System.Windows.Forms.Label();
            this.BTN_Inserir = new System.Windows.Forms.Button();
            this.CB_Sexo = new System.Windows.Forms.ComboBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.BTN_Alterar = new System.Windows.Forms.Button();
            this.BTN_Deletar = new System.Windows.Forms.Button();
            this.LBLCodigo = new System.Windows.Forms.Label();
            this.TXTId = new System.Windows.Forms.TextBox();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.PN_dados = new System.Windows.Forms.Panel();
            this.PN_dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTNome
            // 
            this.TXTNome.Location = new System.Drawing.Point(108, 39);
            this.TXTNome.Name = "TXTNome";
            this.TXTNome.Size = new System.Drawing.Size(244, 20);
            this.TXTNome.TabIndex = 0;
            // 
            // DTPNascimento
            // 
            this.DTPNascimento.Location = new System.Drawing.Point(108, 65);
            this.DTPNascimento.Name = "DTPNascimento";
            this.DTPNascimento.Size = new System.Drawing.Size(244, 20);
            this.DTPNascimento.TabIndex = 2;
            // 
            // TXTEmail
            // 
            this.TXTEmail.Location = new System.Drawing.Point(108, 118);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(244, 20);
            this.TXTEmail.TabIndex = 3;
            // 
            // TXTCPF
            // 
            this.TXTCPF.Location = new System.Drawing.Point(247, 91);
            this.TXTCPF.Name = "TXTCPF";
            this.TXTCPF.Size = new System.Drawing.Size(105, 20);
            this.TXTCPF.TabIndex = 4;
            // 
            // LBLNome
            // 
            this.LBLNome.AutoSize = true;
            this.LBLNome.Location = new System.Drawing.Point(25, 42);
            this.LBLNome.Name = "LBLNome";
            this.LBLNome.Size = new System.Drawing.Size(35, 13);
            this.LBLNome.TabIndex = 5;
            this.LBLNome.Text = "Nome";
            // 
            // LBLDtNascimento
            // 
            this.LBLDtNascimento.AutoSize = true;
            this.LBLDtNascimento.Location = new System.Drawing.Point(25, 71);
            this.LBLDtNascimento.Name = "LBLDtNascimento";
            this.LBLDtNascimento.Size = new System.Drawing.Size(77, 13);
            this.LBLDtNascimento.TabIndex = 6;
            this.LBLDtNascimento.Text = "Dt.Nascimento";
            // 
            // LBLSexo
            // 
            this.LBLSexo.AutoSize = true;
            this.LBLSexo.Location = new System.Drawing.Point(25, 94);
            this.LBLSexo.Name = "LBLSexo";
            this.LBLSexo.Size = new System.Drawing.Size(31, 13);
            this.LBLSexo.TabIndex = 7;
            this.LBLSexo.Text = "Sexo";
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Location = new System.Drawing.Point(25, 121);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(35, 13);
            this.LBLEmail.TabIndex = 8;
            this.LBLEmail.Text = "E-mail";
            // 
            // LBLCpf
            // 
            this.LBLCpf.AutoSize = true;
            this.LBLCpf.Location = new System.Drawing.Point(214, 94);
            this.LBLCpf.Name = "LBLCpf";
            this.LBLCpf.Size = new System.Drawing.Size(27, 13);
            this.LBLCpf.TabIndex = 9;
            this.LBLCpf.Text = "CPF";
            // 
            // BTN_Inserir
            // 
            this.BTN_Inserir.Location = new System.Drawing.Point(389, 12);
            this.BTN_Inserir.Name = "BTN_Inserir";
            this.BTN_Inserir.Size = new System.Drawing.Size(103, 23);
            this.BTN_Inserir.TabIndex = 10;
            this.BTN_Inserir.Text = "Inserir";
            this.BTN_Inserir.UseVisualStyleBackColor = true;
            this.BTN_Inserir.Click += new System.EventHandler(this.BTNInserir_Click);
            // 
            // CB_Sexo
            // 
            this.CB_Sexo.FormattingEnabled = true;
            this.CB_Sexo.Location = new System.Drawing.Point(108, 91);
            this.CB_Sexo.Name = "CB_Sexo";
            this.CB_Sexo.Size = new System.Drawing.Size(100, 21);
            this.CB_Sexo.TabIndex = 11;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(389, 41);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(103, 23);
            this.BTN_Buscar.TabIndex = 12;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Alterar
            // 
            this.BTN_Alterar.Location = new System.Drawing.Point(389, 70);
            this.BTN_Alterar.Name = "BTN_Alterar";
            this.BTN_Alterar.Size = new System.Drawing.Size(103, 23);
            this.BTN_Alterar.TabIndex = 13;
            this.BTN_Alterar.Text = "Alterar";
            this.BTN_Alterar.UseVisualStyleBackColor = true;
            this.BTN_Alterar.Click += new System.EventHandler(this.BTN_Alterar_Click);
            // 
            // BTN_Deletar
            // 
            this.BTN_Deletar.Location = new System.Drawing.Point(389, 100);
            this.BTN_Deletar.Name = "BTN_Deletar";
            this.BTN_Deletar.Size = new System.Drawing.Size(103, 23);
            this.BTN_Deletar.TabIndex = 14;
            this.BTN_Deletar.Text = "Deletar";
            this.BTN_Deletar.UseVisualStyleBackColor = true;
            this.BTN_Deletar.Click += new System.EventHandler(this.BTN_Deletar_Click);
            // 
            // LBLCodigo
            // 
            this.LBLCodigo.AutoSize = true;
            this.LBLCodigo.Location = new System.Drawing.Point(25, 17);
            this.LBLCodigo.Name = "LBLCodigo";
            this.LBLCodigo.Size = new System.Drawing.Size(40, 13);
            this.LBLCodigo.TabIndex = 15;
            this.LBLCodigo.Text = "Código";
            // 
            // TXTId
            // 
            this.TXTId.Enabled = false;
            this.TXTId.Location = new System.Drawing.Point(108, 14);
            this.TXTId.Name = "TXTId";
            this.TXTId.Size = new System.Drawing.Size(46, 20);
            this.TXTId.TabIndex = 16;
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Location = new System.Drawing.Point(389, 130);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(103, 23);
            this.BTN_Cancelar.TabIndex = 17;
            this.BTN_Cancelar.Text = "Cancelar";
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Location = new System.Drawing.Point(389, 159);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(103, 23);
            this.BTN_Salvar.TabIndex = 18;
            this.BTN_Salvar.Text = "Salvar";
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // PN_dados
            // 
            this.PN_dados.Controls.Add(this.TXTCPF);
            this.PN_dados.Controls.Add(this.TXTNome);
            this.PN_dados.Controls.Add(this.DTPNascimento);
            this.PN_dados.Controls.Add(this.TXTId);
            this.PN_dados.Controls.Add(this.TXTEmail);
            this.PN_dados.Controls.Add(this.LBLCodigo);
            this.PN_dados.Controls.Add(this.LBLNome);
            this.PN_dados.Controls.Add(this.LBLDtNascimento);
            this.PN_dados.Controls.Add(this.LBLSexo);
            this.PN_dados.Controls.Add(this.LBLEmail);
            this.PN_dados.Controls.Add(this.CB_Sexo);
            this.PN_dados.Controls.Add(this.LBLCpf);
            this.PN_dados.Location = new System.Drawing.Point(14, 21);
            this.PN_dados.Name = "PN_dados";
            this.PN_dados.Size = new System.Drawing.Size(369, 154);
            this.PN_dados.TabIndex = 19;
            // 
            // FRMPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 187);
            this.Controls.Add(this.PN_dados);
            this.Controls.Add(this.BTN_Salvar);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Deletar);
            this.Controls.Add(this.BTN_Alterar);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.BTN_Inserir);
            this.Name = "FRMPessoa";
            this.Text = "Cadasrtro de Pessoa";
            this.Load += new System.EventHandler(this.FRMPessoa_Load);
            this.PN_dados.ResumeLayout(false);
            this.PN_dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXTNome;
        private System.Windows.Forms.DateTimePicker DTPNascimento;
        private System.Windows.Forms.TextBox TXTEmail;
        private System.Windows.Forms.TextBox TXTCPF;
        private System.Windows.Forms.Label LBLNome;
        private System.Windows.Forms.Label LBLDtNascimento;
        private System.Windows.Forms.Label LBLSexo;
        private System.Windows.Forms.Label LBLEmail;
        private System.Windows.Forms.Label LBLCpf;
        private System.Windows.Forms.Button BTN_Inserir;
        private System.Windows.Forms.ComboBox CB_Sexo;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.Button BTN_Alterar;
        private System.Windows.Forms.Button BTN_Deletar;
        private System.Windows.Forms.Label LBLCodigo;
        private System.Windows.Forms.TextBox TXTId;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.Panel PN_dados;
    }
}

