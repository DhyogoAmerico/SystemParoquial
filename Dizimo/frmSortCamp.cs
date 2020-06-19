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
    public partial class frmSortCamp : Form
    {
        public frmSortCamp()
        {
            InitializeComponent();
        }

        public List<int> sort = null;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmSortCamp_Load(object sender, EventArgs e)
        {
            sort = new List<int>();
            
        }

        private void button2_Click(object sender, EventArgs e) //Botão Sortear
        {
            Random num = new Random();
            int N = 0;

            N = num.Next(1, 500); //Aleatorio de 1 a 500

            if (sort != null)
            {
                foreach(int X in sort)
                {
                    if (N == X)
                    {
                        N = num.Next(1, 500);
                    }
                }
                sort.Add(N);
            }

            textBox1.Text = N.ToString();

            label1.Text = "GANHADOR!!";
            label2.Text = "Parabéns ao Devoto de número " + N.ToString() + "!";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
