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
    public partial class frmAddContato : Form
    {
        public frmAddContato()
        {
            InitializeComponent();
        }

        Agenda ag = new Agenda();
        GrupoParoquial GP = new GrupoParoquial();

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            checkPesquisar.Checked = false;
            checkGrupo.Checked = false;
            cmbGrupo.Enabled = false;
            cmdRemover.Enabled = false;

            cmbGrupo.DisplayMember = "NomeGrupo";
            cmbGrupo.ValueMember = "idGrupo";
            cmbGrupo.DataSource = GP.ListarGrupo().Tables[0];

            CarregarComBoxPesquisar();
            Limpar();
            //cmbPesquisar.SelectedIndex = -1;
        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                ag.NomeContato = txtNomeContato.Text;
                ag.Tel1Contato = txtTel1.Text;
                ag.Tel2Contato = txtTel2.Text;
                ag.Tel3Contato = txtTel3.Text;
                ag.DescricaoContato = txtDescricao.Text;
                if (checkGrupo.Checked)
                {
                    ag.IdGrupo = int.Parse(cmbGrupo.SelectedValue.ToString());
                }
                else
                {
                    ag.IdGrupo = 0;
                }
                if (checkPesquisar.Checked == false) //Adicionar
                {
                    ag.IncluirContato();
                    MessageBox.Show("Registro Incluído!","Cadastrado!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Limpar();
                }
                else  //Editar/Salvar
                {
                    ag.AlterarContato();
                    MessageBox.Show("Registro Alterado!","Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    checkPesquisar.Checked = false;
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Verifique a entrada de dados.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Atualizar comboBox de pesquisa
            CarregarComBoxPesquisar();
            Limpar();
            cmdRemover.Enabled = false;
        }

        private void checkGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGrupo.Checked)
            {
                cmbGrupo.Enabled = true;
            }
            else
            {
                cmbGrupo.Enabled = false;
            }
        }

        private void cmbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkPesquisar.Checked == true)
                {
                    ag.IdContato = int.Parse(cmbPesquisar.SelectedValue.ToString());
                    ag.ConsultarContato();

                    txtNomeContato.Text = ag.NomeContato;
                    txtTel1.Text = ag.Tel1Contato;
                    txtTel2.Text = ag.Tel2Contato;
                    txtTel3.Text = ag.Tel3Contato;
                    txtDescricao.Text = ag.DescricaoContato;
                    if (ag.IdGrupo == 0)
                    {
                        cmbGrupo.Enabled = false;
                        checkGrupo.Checked = false;
                    }
                    else
                    {
                        checkGrupo.Checked = true;
                        cmbGrupo.Enabled = true;
                        cmbGrupo.SelectedIndex = ag.IdGrupo - 1;
                    }
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Verifique a entrada de dados!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ag.IdGrupo = int.Parse(cmbGrupo.SelectedValue.ToString());
        }

        private void cmdRemover_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Deseja mesmo excluir este contato?", "Alerta!", MessageBoxButtons.YesNo))
            {
                ag.ExcluirContato();
                MessageBox.Show("Contato excluído com sucesso!");
                Limpar();
            }
            cmdRemover.Enabled = false;
        }

        public void Limpar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtTel3.Text = "";

            ag.NomeContato = "";//Para fazer a consulta do listar

            checkGrupo.Checked = false;
            cmbGrupo.SelectedIndex = 0;
        }

        private void CarregarComBoxPesquisar()
        {
            Limpar();
            cmbPesquisar.DisplayMember = "NomeContato";
            cmbPesquisar.ValueMember = "idContato";
            cmbPesquisar.DataSource = ag.ListarContato().Tables[0];
        }

        private void checkPesquisar_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPesquisar.Checked == true)
            {
                cmbPesquisar.Enabled = true;
                cmdRemover.Enabled = true;
            }
            else
            {
                cmdRemover.Enabled = false;
                cmbPesquisar.Enabled = false;
                Limpar();
            }
        }
    }
}
