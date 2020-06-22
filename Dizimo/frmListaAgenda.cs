using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dizimo
{
    public partial class frmListaAgenda : Form
    {
        public frmListaAgenda()
        {
            InitializeComponent();
        }

        Agenda AG = new Agenda();
        GrupoParoquial GP = new GrupoParoquial();
        int Id = 0;

        private void frmListaAgenda_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Iniciar conversa com número do contato selecionado.");
            AG.NomeContato = "";
            PreencherDataGrid();
            Limpar();
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            frmAddContato AddContato = new frmAddContato();
            AddContato.ShowDialog();
            AG.NomeContato = "";
            PreencherDataGrid();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            AG.NomeContato = txtPesquisarNome.Text;
            PreencherDataGrid();
            Limpar();
        }
        private void FormatarGrid()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows[0].Selected = true;
        }

        private void PreencherDataGrid()
        {
            dataGridView1.DataSource = AG.ListarContato().Tables[0];
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            FormatarGrid();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Nenhum item selecionado", "Falha da seleção do Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                AG.IdContato = Id;
                AG.ConsultarContato();

                txtTel1.Text = AG.Tel1Contato;
                txtTel2.Text = AG.Tel2Contato;
                txtTel3.Text = AG.Tel3Contato;
                txtDescrição.Text = AG.DescricaoContato;
                if(AG.IdGrupo == 0)
                {
                    lblGrupo.Text = "";
                }
                else
                {
                    GP.IdGrupo = AG.IdGrupo;
                    GP.ConsultarGrupo();
                    lblGrupo.Text = "Participa do(a) " + GP.NomeGrupo;
                }
            }
            catch
            {
                MessageBox.Show("Nenhum item selecionado", "Falha da seleção do Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar()
        {
            txtDescrição.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtTel3.Text = "";

            rdbTel1.Checked = false;
            rdbTel2.Checked = false;
            rdbTel3.Checked = false;

            lblGrupo.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(rdbTel1.Checked == true)
            {
                if (txtTel1.Text != "")
                {
                    string num = "35" + txtTel1.Text;
                    string url = "http://api.whatsapp.com/send?1=pt_BR&phone=55" + num;
                    System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                    pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(url);
                    pStart.Start();
                }
                else
                    MessageBox.Show("Não há um número cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rdbTel2.Checked == true)
            {
                if (txtTel2.Text != "")
                {
                    string num = "35" + txtTel2.Text;
                    string url = "http://api.whatsapp.com/send?1=pt_BR&phone=55" + num;
                    System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                    pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(url);
                    pStart.Start();
                }
                else
                    MessageBox.Show("Não há um número cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rdbTel3.Checked == true)
            {
                if (txtTel3.Text != "")
                {
                    string num = "35" + txtTel3.Text;
                    string url = "http://api.whatsapp.com/send?1=pt_BR&phone=55" + num;
                    System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                    pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(url);
                    pStart.Start();
                }
                else
                    MessageBox.Show("Não há um número cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Nenhum número para Whatsapp selecionado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            rdbTel1.Checked = false;
            rdbTel2.Checked = false;
            rdbTel3.Checked = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            AG.IdContato = 0;
            GP.IdGrupo = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
