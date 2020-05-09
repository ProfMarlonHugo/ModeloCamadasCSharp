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
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLPessoa bllpessoa = new BLLPessoa(cx);

            MODELOPassoa p = new MODELOPassoa();
            p.Nome = TXTNome.Text;
            p.DataNascimento = new DateTime(DTPNascimento.Value.Year,
                DTPNascimento.Value.Month,
                DTPNascimento.Value.Day);
            p.Sexo = TXTSexo.Text;
            p.Email = TXTEmail.Text;

            bllpessoa.Incluir(p);
            MessageBox.Show("Usuario inserido com sucesso id:" + p.Id);
        }
    }
}
