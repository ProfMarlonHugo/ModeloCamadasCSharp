using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using DAL;
using BLL;
using MySql.Data.MySqlClient;

namespace PadraoDeProjetoEmCamadas
{
    public partial class FRMPessoa : Form
    {
        public FRMPessoa()
        {
            InitializeComponent();
        }

        private void BTNInserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
        }

        private void FRMPessoa_Load(object sender, EventArgs e)
        {
            CB_Sexo.Items.Add("Masculino");
            CB_Sexo.Items.Add("Feminino");
            CB_Sexo.Items.Add("Outros");
            alterapropriedades(1);
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

        public void alterapropriedades(int op)
        {
            //op = operacao
            // 1 = Inserir | Buscar
            // 2 = Inserir | Alterar
            // 3 = Alterar | Excluir
            BTN_Inserir.Enabled = false;
            BTN_Alterar.Enabled = false;
            BTN_Buscar.Enabled = false;
            BTN_Deletar.Enabled = false;
            BTN_Cancelar.Enabled = false;
            BTN_Salvar.Enabled = false;
            PN_dados.Enabled = false;

            switch (op)
            {
                case 1:
                    BTN_Inserir.Enabled = true;
                    BTN_Buscar.Enabled = true;
                    break;
                case 2:
                    PN_dados.Enabled = true;
                    BTN_Buscar.Enabled = true;
                    BTN_Cancelar.Enabled = true;
                    BTN_Salvar.Enabled = true;
                    break;
                case 3:
                    PN_dados.Enabled = true;
                    BTN_Alterar.Enabled = true;
                    BTN_Deletar.Enabled = true;
                    BTN_Cancelar.Enabled = true;
                    break;
            } 
        }

        private void popularcampos(MODELOPassoa p) {

            DTPNascimento.Text =  Convert.ToString(p.DataNascimento);
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

        private void button1_Click(object sender, EventArgs e)
        {
            FRMLocalizar f = new FRMLocalizar();
            f.ShowDialog();

            popularcampos(f.modelpessoa);

            alterapropriedades(3);
        }

        private void BTN_Alterar_Click(object sender, EventArgs e)
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

        private void BTN_Deletar_Click(object sender, EventArgs e)
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

        private void BTN_Salvar_Click(object sender, EventArgs e)
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

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            alterapropriedades(1);
        }
    }
}
