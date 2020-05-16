using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class FRMLocalizar : Form
    {
        public string nome = "";
        public FRMLocalizar()
        {
            InitializeComponent();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLPessoa bllpessoa = new BLLPessoa(cx);
            DataTable tabela = bllpessoa.Localizar(TXTBusca.Text);
            DGVDados.DataSource = tabela;
        }

        private void DGVDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.nome = DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Close();
        }
    }
}
