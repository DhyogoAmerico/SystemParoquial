using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizimo
{
    public partial class FrmCadastrarGrupo : Form
    {
        public FrmCadastrarGrupo()
        {
            InitializeComponent();
        }
        GrupoParoquial GP = new GrupoParoquial();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGrupos_Click(object sender, EventArgs e)
        {
           // cmbGrupos.Enabled = false;
        }

        private void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GP.IdGrupo = int.Parse(cmbGrupos.SelectedValue.ToString());
            GP.ConsultarGrupo();
            Limpar();
            txtNomeGrupo.Text = GP.NomeGrupo;
            txtCooGrupo.Text = GP.CooGrupo;
        }

        private void FrmCadastrarGrupo_Load(object sender, EventArgs e)
        {
            Limpar();
            rdbNovo.Checked = false;
            rdbAtalizar.Checked = false;
            if ((rdbAtalizar.Checked == false)&&(rdbNovo.Checked == false))
            {
                txtNomeGrupo.Enabled = false;
                txtCooGrupo.Enabled = false;
                cmbGrupos.Enabled = false;
            }
        }

        private void cmdCadEdit_Click(object sender, EventArgs e)
        {
            if (rdbAtalizar.Checked) 
            {
                //Editar
                GP.NomeGrupo = txtNomeGrupo.Text;
                GP.CooGrupo = txtCooGrupo.Text;
                GP.AlterarGrupo();
                Limpar();
                cmbGrupos.Enabled = true;
            }
            else if (rdbNovo.Checked)
            {
                //Cadastrar
                GP.NomeGrupo = txtNomeGrupo.Text;
                GP.CooGrupo = txtCooGrupo.Text;
                GP.IncluirGrupo();
                Limpar();
            }
        }

        public void Limpar()
        {
            txtCooGrupo.Clear();
            txtNomeGrupo.Clear();
        }

        private void rdbNovo_CheckedChanged(object sender, EventArgs e)
        {
            cmbGrupos.Enabled = false;
            txtNomeGrupo.Enabled = true;
            txtCooGrupo.Enabled = true;
            Limpar();
        }

        private void rdbAtalizar_CheckedChanged(object sender, EventArgs e)
        {
            GP.NomeGrupo = "";
            cmbGrupos.DisplayMember = "NomeGrupo";//Vai Mostrar
            cmbGrupos.ValueMember = "idGrupo";//Vai trabalhar
            cmbGrupos.DataSource = GP.ListarGrupo().Tables[0];
            GP.IdGrupo = int.Parse(cmbGrupos.SelectedValue.ToString());
            GP.ConsultarGrupo();

            cmbGrupos.Enabled = true;
            txtNomeGrupo.Enabled = true;
            txtCooGrupo.Enabled = true;
            Limpar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
