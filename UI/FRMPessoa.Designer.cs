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
            this.TXTSexo = new System.Windows.Forms.TextBox();
            this.DTPNascimento = new System.Windows.Forms.DateTimePicker();
            this.TXTEmail = new System.Windows.Forms.TextBox();
            this.TXTCPF = new System.Windows.Forms.TextBox();
            this.LBLNome = new System.Windows.Forms.Label();
            this.LBLDtNascimento = new System.Windows.Forms.Label();
            this.LBLSexo = new System.Windows.Forms.Label();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.LBLCpf = new System.Windows.Forms.Label();
            this.BTNInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTNome
            // 
            this.TXTNome.Location = new System.Drawing.Point(83, 37);
            this.TXTNome.Name = "TXTNome";
            this.TXTNome.Size = new System.Drawing.Size(105, 20);
            this.TXTNome.TabIndex = 0;
            // 
            // TXTSexo
            // 
            this.TXTSexo.Location = new System.Drawing.Point(83, 89);
            this.TXTSexo.Name = "TXTSexo";
            this.TXTSexo.Size = new System.Drawing.Size(105, 20);
            this.TXTSexo.TabIndex = 1;
            // 
            // DTPNascimento
            // 
            this.DTPNascimento.Location = new System.Drawing.Point(83, 63);
            this.DTPNascimento.Name = "DTPNascimento";
            this.DTPNascimento.Size = new System.Drawing.Size(244, 20);
            this.DTPNascimento.TabIndex = 2;
            // 
            // TXTEmail
            // 
            this.TXTEmail.Location = new System.Drawing.Point(83, 116);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(105, 20);
            this.TXTEmail.TabIndex = 3;
            // 
            // TXTCPF
            // 
            this.TXTCPF.Location = new System.Drawing.Point(83, 142);
            this.TXTCPF.Name = "TXTCPF";
            this.TXTCPF.Size = new System.Drawing.Size(105, 20);
            this.TXTCPF.TabIndex = 4;
            // 
            // LBLNome
            // 
            this.LBLNome.AutoSize = true;
            this.LBLNome.Location = new System.Drawing.Point(0, 40);
            this.LBLNome.Name = "LBLNome";
            this.LBLNome.Size = new System.Drawing.Size(35, 13);
            this.LBLNome.TabIndex = 5;
            this.LBLNome.Text = "Nome";
            // 
            // LBLDtNascimento
            // 
            this.LBLDtNascimento.AutoSize = true;
            this.LBLDtNascimento.Location = new System.Drawing.Point(0, 69);
            this.LBLDtNascimento.Name = "LBLDtNascimento";
            this.LBLDtNascimento.Size = new System.Drawing.Size(77, 13);
            this.LBLDtNascimento.TabIndex = 6;
            this.LBLDtNascimento.Text = "Dt.Nascimento";
            // 
            // LBLSexo
            // 
            this.LBLSexo.AutoSize = true;
            this.LBLSexo.Location = new System.Drawing.Point(0, 92);
            this.LBLSexo.Name = "LBLSexo";
            this.LBLSexo.Size = new System.Drawing.Size(31, 13);
            this.LBLSexo.TabIndex = 7;
            this.LBLSexo.Text = "Sexo";
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Location = new System.Drawing.Point(0, 119);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(35, 13);
            this.LBLEmail.TabIndex = 8;
            this.LBLEmail.Text = "E-mail";
            // 
            // LBLCpf
            // 
            this.LBLCpf.AutoSize = true;
            this.LBLCpf.Location = new System.Drawing.Point(0, 145);
            this.LBLCpf.Name = "LBLCpf";
            this.LBLCpf.Size = new System.Drawing.Size(27, 13);
            this.LBLCpf.TabIndex = 9;
            this.LBLCpf.Text = "CPF";
            // 
            // BTNInserir
            // 
            this.BTNInserir.Location = new System.Drawing.Point(12, 180);
            this.BTNInserir.Name = "BTNInserir";
            this.BTNInserir.Size = new System.Drawing.Size(75, 23);
            this.BTNInserir.TabIndex = 10;
            this.BTNInserir.Text = "Inserir";
            this.BTNInserir.UseVisualStyleBackColor = true;
            this.BTNInserir.Click += new System.EventHandler(this.BTNInserir_Click);
            // 
            // FRMPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 215);
            this.Controls.Add(this.BTNInserir);
            this.Controls.Add(this.LBLCpf);
            this.Controls.Add(this.LBLEmail);
            this.Controls.Add(this.LBLSexo);
            this.Controls.Add(this.LBLDtNascimento);
            this.Controls.Add(this.LBLNome);
            this.Controls.Add(this.TXTCPF);
            this.Controls.Add(this.TXTEmail);
            this.Controls.Add(this.DTPNascimento);
            this.Controls.Add(this.TXTSexo);
            this.Controls.Add(this.TXTNome);
            this.Name = "FRMPessoa";
            this.Text = "Cadasrtro de Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTNome;
        private System.Windows.Forms.TextBox TXTSexo;
        private System.Windows.Forms.DateTimePicker DTPNascimento;
        private System.Windows.Forms.TextBox TXTEmail;
        private System.Windows.Forms.TextBox TXTCPF;
        private System.Windows.Forms.Label LBLNome;
        private System.Windows.Forms.Label LBLDtNascimento;
        private System.Windows.Forms.Label LBLSexo;
        private System.Windows.Forms.Label LBLEmail;
        private System.Windows.Forms.Label LBLCpf;
        private System.Windows.Forms.Button BTNInserir;
    }
}

