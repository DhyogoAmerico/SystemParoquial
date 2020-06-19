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
    public partial class frmRecibosEntrada : Form
    {
        public frmRecibosEntrada()
        {
            InitializeComponent();
        }

        Dizimista Diz = null;
        RecibosEntrada Rb = null;
        string status = "Navegando";

        private void HabilitarControle()
        {
            cmdInserir.Enabled = (status == "Navegando");

            cmdExcluir.Enabled = (status == "Editando");
        }

        private void frmRecibosEntrada_Load(object sender, EventArgs e)
        {
            cmdExcluir.Enabled = false;
            cmdPesq.Enabled = false;
        }
    }
}
