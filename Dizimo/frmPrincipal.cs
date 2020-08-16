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
    //Os botões principais são independentes, cada botão possui uma variavel do tipo bool
    //que ativa os outros botões correspondentes a ele.
    //Há dois groupBox (Diversos e Outros) que refere-se aos botões correspondentes aos 
    //principais. Em diviersos os botões não nomeados em desing como: cmd1, cmd2, cmd3 e cmd4.
    //Em Outros é: cmd01, cmd02, cmd03 e cmd 04.
    //Para ativa cada botão correspondente é verificado qual varivel é "true", sendo que ela ativa as 
    // funções do mesmo.
    // A função Visi torna todos os botões e groupBox invisiveis, e também deica as variaveis principais falsas para reiniciar.
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        bool Dizimo = false;
        bool Campanha = false;
        bool Intencao = false;
        //bool Agenda = false;
        //bool GrupoP = false;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Visi();
        }

        private void cmdCampanha_Click(object sender, EventArgs e)
        {
            Visi();
            gpbOutros.Visible = false;
            gpbDiversos.Visible = true;
            cmd1.Text = "Sorteio";
            cmd2.Visible = false;
            cmd3.Visible = false;
            cmd4.Visible = false;
            Campanha = true;
        }

        private void cmdDizimo_Click(object sender, EventArgs e)
        {
            Visi();
            Dizimo = true;
            gpbDiversos.Visible = true;
            cmd1.Text = "Cadastrar Dizimista";
            cmd2.Text = "Filtrar Dizimistas";
            cmd3.Text = "Pesquisar Dizimista";
            cmd2.Visible = true;
            cmd3.Visible = true;
            cmd4.Visible = false;
            cmd01.Text = "Filtrar por Data de Nascimento";
            cmd02.Text = "Filtrar por Data de Casamento";
            cmd03.Text = "Filtrar por Setor";
        }

        private void cmdIntencoes_Click(object sender, EventArgs e)
        {
            Visi();
            Intencao = true;
            gpbDiversos.Visible = true;           
            cmd1.Text = "Criar intenção";
            cmd2.Visible = false;
            cmd3.Visible = false;
            cmd4.Visible = false;
        }

        private void cmdAgenda_Click(object sender, EventArgs e)
        {
            Visi();
            //Agenda = true;
            frmListaAgenda listAgenda = new frmListaAgenda();
            listAgenda.ShowDialog();
        }

        private void cmdGrupoP_Click(object sender, EventArgs e)
        {
            Visi();
            //GrupoP = true;
            frmGrupo grupoP = new frmGrupo();
            grupoP.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //cmd 1,2,3,4 = grupo Diversos
        private void cmd1_Click(object sender, EventArgs e)
        {
            if (Dizimo)
            {
                frmDizimista Diz = new frmDizimista();
                Diz.ShowDialog();
            }
            else if (Campanha)
            {
                frmSortCamp fs = new frmSortCamp();
                fs.ShowDialog();
            }
            else if (Intencao)
            {
                frmIntenções fI = new frmIntenções();
                fI.ShowDialog();
            }

        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if (Dizimo)
            {
                gpbOutros.Visible = true;
                cmd04.Visible = false;
            }
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            if (Dizimo)
            {
                Dizimista D = new Dizimista();
                PesquisarDiz ps = new PesquisarDiz(D);
                ps.ShowDialog();
            }
        }

        private void cmd4_Click(object sender, EventArgs e)
        {

        }

        //cmd 01,02,03,04 = grupo Outros

        private void d_Click(object sender, EventArgs e)
        {
            if (Dizimo)
            {
                //Filtrar Dizimista pela data de nascimento 
                frmFiltroDizimista FDz = new frmFiltroDizimista();
                FDz.Dn = 1;
                FDz.Dc = 0;
                FDz.ShowDialog();
            }
        }//cmd01

        private void cmd02_Click(object sender, EventArgs e)
        {
            if (Dizimo)
            {
                //Filtrar Dizimistas pela data de casamento
                frmFiltroDizimista FDiz = new frmFiltroDizimista();
                FDiz.Dc = 1;
                FDiz.Dn = 0;
                FDiz.ShowDialog();
            }
        }

        private void cmd03_Click(object sender, EventArgs e)
        {
            if (Dizimo)
            {
                frmFiltrarPorSetor FS = new frmFiltrarPorSetor();
                FS.ShowDialog();
            }
        }

        private void cmd04_Click(object sender, EventArgs e)
        {

        }

        private void gpbDiversos_Enter(object sender, EventArgs e)
        {
            if (gpbDiversos.Visible)
            {
                
            }
        }

        private void Visi() //Deixar campos Invisiveis
        {
            foreach(Control item in this.Controls.OfType<Button>())
            {
                item.Visible = false;
            }
            cmdCampanha.Visible = true;
            cmdDizimo.Visible = true;
            cmdIntencoes.Visible = true;
            cmdGrupoP.Visible = true;
            cmdAgenda.Visible = true;

            gpbDiversos.Visible = false;
            gpbOutros.Visible = false;

            Dizimo = false;
            Campanha = false;
            Intencao = false;
            /*Agenda = false;
            GrupoP = false;*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Today.ToShortDateString();
        }
    }
}
