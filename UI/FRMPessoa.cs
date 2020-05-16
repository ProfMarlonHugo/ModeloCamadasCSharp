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
                MessageBox.Show("Usuario inserido com sucesso id:" + p.Id);
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate")){
                    MessageBox.Show("Registro j'a existe no banco de dados");
                }else
                {
                    MessageBox.Show("Falha ao inserir errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }
        }

        private void FRMPessoa_Load(object sender, EventArgs e)
        {
            CB_Sexo.Items.Add("Masculino");
            CB_Sexo.Items.Add("Feminino");
            CB_Sexo.Items.Add("Outros");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMLocalizar f = new FRMLocalizar();
            f.ShowDialog();

            TXTNome.Text =  f.nome;
        }
    }
}
