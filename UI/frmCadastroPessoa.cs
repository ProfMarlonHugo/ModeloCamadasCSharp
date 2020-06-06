using BLL;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmCadastroPessoa : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        private string fotoPessoa = "";
        public frmCadastroPessoa(frmPrincipal f)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            f.Text = "Menu - Cadastro pessoa";
        }

        public void limparCampos()
        {
            TXTCPF.Clear();
            TXTEmail.Clear();
            TXTId.Clear();
            TXTNome.Clear();
            DTPNascimento.Text = "";
            CB_Sexo.SelectedItem = null;
            PB_img.Image = null;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
            alterarPropriedadeImagem(1);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FRMLocalizar f = new FRMLocalizar();
            f.ShowDialog();

            popularcampos(f.modelpessoa);

            alterapropriedades(3);
            alterarPropriedadeImagem(1);
        }

        private void popularcampos(MODELOPassoa p)
        {
            if (p != null)
            {
                DTPNascimento.Text = Convert.ToString(p.DataNascimento);
                TXTNome.Text = p.Nome;
                TXTCPF.Text = p.Cpf;
                TXTEmail.Text = p.Email;
                TXTId.Text = p.Id.ToString();
                if (p.Foto != null)
                    PB_img.Image = p.getImagem();

                switch (p.Sexo)
                {
                    case "M":
                        CB_Sexo.SelectedItem = "Masculino";
                        break;
                    case "F":
                        CB_Sexo.SelectedItem = "Feminino";
                        break;
                    case "O":
                        CB_Sexo.SelectedItem = "Outro";
                        break;

                }
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLPessoa bllpessoa = new BLLPessoa(cx);

                MODELOPassoa p = new MODELOPassoa();
                p.Nome = TXTNome.Text;
                p.DataNascimento = new DateTime(DTPNascimento.Value.Year,
                    DTPNascimento.Value.Month,
                    DTPNascimento.Value.Day);

                switch (CB_Sexo.SelectedItem.ToString())
                {
                    case "Masculino":
                        p.Sexo = "M";
                        break;
                    case "Feminino":
                        p.Sexo = "F";
                        break;
                    case "Outro":
                        p.Sexo = "O";
                        break;
                }

                p.Email = TXTEmail.Text;
                p.Cpf = TXTCPF.Text;
                p.CarregaImagem(fotoPessoa);
                p.Id = Convert.ToInt32(TXTId.Text);

                bllpessoa.Alterar(p);
                MessageBox.Show("Usuario alterado com sucesso.");

                limparCampos();
                alterapropriedades(1);
                alterarPropriedadeImagem(0);
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro já existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao alterar errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar errro geral:" + ex.Message);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLPessoa bllpessoa = new BLLPessoa(cx);
                bllpessoa.Excluir(Convert.ToInt32(TXTId.Text));
                MessageBox.Show("Usuario excluido com sucesso.");

                limparCampos();
                alterapropriedades(1);
                alterarPropriedadeImagem(0);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao excluir erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir erro geral:" + ex.Message);
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            alterapropriedades(1);
            alterarPropriedadeImagem(0);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLPessoa bllpessoa = new BLLPessoa(cx);

                MODELOPassoa p = new MODELOPassoa();
                p.Nome = TXTNome.Text;
                p.DataNascimento = new DateTime(DTPNascimento.Value.Year,
                    DTPNascimento.Value.Month,
                    DTPNascimento.Value.Day);

                switch (CB_Sexo.SelectedItem.ToString())
                {
                    case "Masculino":
                        p.Sexo = "M";
                        break;
                    case "Feminino":
                        p.Sexo = "F";
                        break;
                    case "Outro":
                        p.Sexo = "O";
                        break;
                }

                p.Email = TXTEmail.Text;
                p.Cpf = TXTCPF.Text;
                p.CarregaImagem(fotoPessoa);

                bllpessoa.Incluir(p);
                TXTId.Text = p.Id.ToString(); ;
                MessageBox.Show("Usuario inserido com sucesso id:" + p.Id);

                limparCampos();
                alterapropriedades(1);
                alterarPropriedadeImagem(0);
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro j'a existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }
        }

        private void frmCadastroPessoa_Load(object sender, EventArgs e)
        {
            CB_Sexo.Items.Add("Masculino");
            CB_Sexo.Items.Add("Feminino");
            CB_Sexo.Items.Add("Outros");
            alterarPropriedadeImagem(0);
        }

        private void alterarPropriedadeImagem(int op)
        {
            if(op == 0)
            {
                btn_buscar_img.Enabled = false;
                btn_remover_img.Enabled = false;
            } else if( op == 1)
            {
                btn_buscar_img.Enabled = true;
                btn_remover_img.Enabled = true;
            }
        }

        private void btn_buscar_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            if(! string.IsNullOrEmpty(op.FileName))
            {
                fotoPessoa = op.FileName;
                PB_img.Load(fotoPessoa);
            }
        }

        private void btn_remover_img_Click(object sender, EventArgs e)
        {
            fotoPessoa = "";
            PB_img.Image = null;
        }

        private void TXTCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox;
            //verificar se a tecla precionada é número
            //ref = https://web.fe.up.pt/~ee96100/projecto/Tabela%20ascii.htm
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                // 111.222.333-11
                t.SelectionStart = t.Text.Length + 1;
                if (t.Text.Length == 3 || t.Text.Length == 7)
                    t.Text += ".";
                else if (t.Text.Length == 11)
                    t.Text += "-";

                t.SelectionStart = t.Text.Length + 1;
            }else
            {
                e.Handled = true;
            }
        }

    }
}
