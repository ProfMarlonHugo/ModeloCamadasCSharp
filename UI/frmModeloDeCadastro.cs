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
    public partial class frmModeloDeCadastro : Form
    {
        public frmModeloDeCadastro()
        {
            InitializeComponent();
        }

        private void frmModeloDeCadastro_Load(object sender, EventArgs e)
        {
            alterapropriedades(1);
        }

        public void alterapropriedades(int op)
        {
            //op = operacao
            // 1 = Inserir | Buscar
            // 2 = Inserir | Alterar
            // 3 = Alterar | Excluir
            btn_inserir.Enabled = false;
            btn_alterar.Enabled = false;
            btn_buscar.Enabled = false;
            btn_deletar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_salvar.Enabled = false;
            painel_campos.Enabled = false;

            switch (op)
            {
                case 1:
                    btn_inserir.Enabled = true;
                    btn_buscar.Enabled = true;
                    break;
                case 2:
                    painel_campos.Enabled = true;
                    btn_buscar.Enabled = true;
                    btn_cancelar.Enabled = true;
                    btn_salvar.Enabled = true;
                    break;
                case 3:
                    painel_campos.Enabled = true;
                    btn_alterar.Enabled = true;
                    btn_deletar.Enabled = true;
                    btn_cancelar.Enabled = true;
                    break;
            }
        }
    }
}
