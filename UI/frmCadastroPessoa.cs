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
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
             alterapropriedades(2);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FRMLocalizar f = new FRMLocalizar();
            f.ShowDialog();

            popularcampos(f.modelpessoa);

            alterapropriedades(3);
        }

        private void popularcampos(MODELOPassoa p)
        {

            DTPNascimento.Text = Convert.ToString(p.DataNascimento);
            TXTNome.Text = p.Nome;
            TXTCPF.Text = p.Cpf;
            TXTEmail.Text = p.Email;
            TXTId.Text = p.Id.ToString();
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
                p.Id = Convert.ToInt32(TXTId.Text);

                bllpessoa.Alterar(p);
                MessageBox.Show("Usuario alterado com sucesso.");

                limparCampos();
                alterapropriedades(1);
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

                bllpessoa.Incluir(p);
                TXTId.Text = p.Id.ToString(); ;
                MessageBox.Show("Usuario inserido com sucesso id:" + p.Id);

                limparCampos();
                alterapropriedades(1);
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
            
          
        }
    }
}
