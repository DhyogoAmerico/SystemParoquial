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
    public partial class frmGrupo : Form
    {
        public frmGrupo()
        {
            InitializeComponent();
        }

        GrupoParoquial GP = new GrupoParoquial();
        Agenda AG = new Agenda();

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarGrupo CadGrupo = new FrmCadastrarGrupo();
            CadGrupo.ShowDialog();
            ListGrupo();
        }

        private void FrmGrupo_Load(object sender, EventArgs e)
        {
            lblIntegrantes.Text = "";
            ListGrupo();  
        }

        public void ListGrupo()
        {
            lstGrupos.Items.Clear();
            int ID = GP.UltimoIDGrupo() + 1;//Ultimo ID da tabela GrupoParoquial + o valor 1, para rodar o FOR
            for (int I = 1; I < ID; I++)
            {
                GP.IdGrupo = I;
                GP.ConsultarGrupo();
                lstGrupos.Items.Add(GP.NomeGrupo);
            }
        }

        public void Limpar()
        {
            lblIntegrantes.Text = "";
            //lstMembros.Items.Clear();
        }

        private void lstGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpar();
            try //É preciso tratar exessão gerada 
            {
                GP.IdGrupo = lstGrupos.SelectedIndex + 1;
                GP.ConsultarGrupo();
                lblIntegrantes.Text = "Membros do(a) " + lstGrupos.SelectedItem.ToString();
                
                AG.IdGrupo = GP.IdGrupo;
                listBox1.DisplayMember = "NomeContato";
                listBox1.ValueMember = "idContato";
                listBox1.DataSource = AG.ListarPorGrupo().Tables[0];
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show(x.ToString());
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
