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
    public partial class PesquisarDiz : Form
    {
        Object obj;
        Dizimista D = null;
        public int id;

        public PesquisarDiz(Object x)
        {
            InitializeComponent();
            obj = x;
        }        

        private void FormatarGrid()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows[0].Selected = true;
        }

        private void PesquisarDiz_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Dado não assessível!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Fechar
        {
            id = 0;
            Close();
            MessageBox.Show("Nenhum dos resultados aceitos.");
        }

        private void button1_Click(object sender, EventArgs e) //Confirmar  
        {
            Close();
        }

        private void cmdPesq_Click(object sender, EventArgs e)
        {
            if (obj is Dizimista)
            {
                D = (Dizimista)obj;
                D.Nome_Dizimista = txtPesqNome.Text;
                dataGridView1.DataSource = D.ListarDizimista().Tables[0];
            }
            FormatarGrid();
        }

        private void txtPesqNome_TextChanged(object sender, EventArgs e)
        {
            if (obj is Dizimista)
            {
                D = (Dizimista)obj;
                D.Nome_Dizimista = txtPesqNome.Text;
                dataGridView1.DataSource = D.ListarDizimista().Tables[0];
            }
            FormatarGrid();
        }
    }
}
