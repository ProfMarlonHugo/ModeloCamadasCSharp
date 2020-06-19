using DAL;
using MODELO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmCadastroEmpresa : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {
            DALWebRequest req = new DALWebRequest();

            try
            {
                string JsonResult = req.buscarRegiao();
                MODELORegiao[] modeloregiao =
                    JsonConvert.DeserializeObject<MODELORegiao[]>(JsonResult);
                CB_REGIAO.DataSource = modeloregiao;
                CB_REGIAO.DisplayMember = "nome";
                CB_REGIAO.ValueMember = "id";
                CB_REGIAO.SelectedIndex = -1;

                richTextBox1.Text = JsonResult;
                painel_campos.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private bool carregandoEstados; 
        private void CB_REGIAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (painel_campos.Enabled)
            {
                carregandoEstados = true;
                CB_ESTADOS.DataSource = null;
                CB_MUNICIPIO.DataSource = null;

                DALWebRequest req = new DALWebRequest();
                MODELORegiao modeloreg = (MODELORegiao)CB_REGIAO.SelectedItem;

                string JsonResult = req.buscarEstados(modeloreg.id);
                MODELOEstado[] modeloestado =
                    JsonConvert.DeserializeObject<MODELOEstado[]>(JsonResult);

                CB_ESTADOS.DataSource = modeloestado;
                CB_ESTADOS.DisplayMember = "nome";
                CB_ESTADOS.ValueMember = "id";
                CB_ESTADOS.SelectedIndex = -1;

                richTextBox1.Text = JsonResult;
                carregandoEstados = false;
            }
        }

        private bool carregandoMunicipio;
        private void CB_ESTADOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carregandoEstados)
            {
                carregandoMunicipio = true;
                CB_MUNICIPIO.DataSource = null;

                DALWebRequest req = new DALWebRequest();
                MODELOEstado modeloest = (MODELOEstado)CB_ESTADOS.SelectedItem;

                string JsonResult = req.buscarMunicipios(modeloest.id);
                MODELOMunicipio[] modelomunicipio =
                    JsonConvert.DeserializeObject<MODELOMunicipio[]>(JsonResult);

                CB_MUNICIPIO.DataSource = modelomunicipio;
                CB_MUNICIPIO.DisplayMember = "nome";
                CB_MUNICIPIO.ValueMember = "id";
                CB_MUNICIPIO.SelectedIndex = -1;

                richTextBox1.Text = JsonResult;
                carregandoMunicipio = false;
            }
        }

        private void CB_MUNICIPIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carregandoMunicipio)
            {
                MODELOMunicipio modelomun = (MODELOMunicipio)CB_MUNICIPIO.SelectedItem;
                MessageBox.Show(modelomun.nome);
            }
        }
    }
}
