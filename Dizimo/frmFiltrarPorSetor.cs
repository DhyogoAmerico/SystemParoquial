using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace Dizimo
{
    public partial class frmFiltrarPorSetor : Form
    {
        public frmFiltrarPorSetor()
        {
            InitializeComponent();
        }

        Setor ST = new Setor(); // Para o List Box
        Setor Set = new Setor();

        SqlConnection cn = new SqlConnection();
        SqlCommand cd = new SqlCommand();
        SqlDataReader dr = null;

        public void Conectar()
        {
            string s = "Server=.\\SQLEXPRESS;Database=Dizimo;UID=sa;PWD=123";
            cn.ConnectionString = s;
            cn.Open();
        }

        private void frmFiltrarPorSetor_Load(object sender, EventArgs e)
        {
            for (int I = 1; I < 20; I++)
            {
                ST.IdSetor = I;
                ST.ConsultarSetor();
                listBox1.Items.Add(ST.IdSetor.ToString() + " | " + ST.NomeSetor + " | " + ST.ListarCountSetor(I).ToString());
            }
            
            cmbSetor.DisplayMember = "NomeSetor";
            cmbSetor.ValueMember = "idSetor";
            cmbSetor.DataSource = Set.ListarSetor().Tables[0];
            Set.IdSetor = int.Parse(cmbSetor.SelectedValue.ToString());
            Set.ConsultarSetor();

        }

        private void cmbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set.IdSetor = int.Parse(cmbSetor.SelectedValue.ToString());
            Set.ConsultarSetor();
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument Pd = new PrintDocument();
            Pd.DocumentName = "Relatorio por Setor";

            Pd.BeginPrint += printDocument1_BeginPrint;
            Pd.PrintPage += printDocument1_PrintPage;
            Pd.EndPrint += printDocument1_EndPrint;

            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;

            printDialog1.Document = Pd;
            PrintPreviewDialog PPD = new PrintPreviewDialog();
            PPD.Document = Pd;
            DialogResult R = printDialog1.ShowDialog();
            if (R == DialogResult.OK)
            {
                PPD.ShowDialog();
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            Conectar();

            string sql = "SELECT IdDizimista,Nome_Dizimista, Rua_Dizimista, Num_Dizimista, Bairro_Dizimista FROM Dizimista4 ";
            sql += "INNER JOIN Setor ON Dizimista4.idSetor = Setor.idSetor ";
            sql += "WHERE Dizimista4.idSetor = " + cmbSetor.SelectedValue.ToString();

            cd.Connection = cn;
            cd.CommandText = sql;

            dr = cd.ExecuteReader();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Configurações da página
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsqueda = 25;
            float margemSuperior = 20;
            float alturaFonte = 0;
            string linha = "";

            float LinhaPorPag = 0;

            //PaperSize paper = new PaperSize("A4", 795, 1137);
            //e.PageSettings.PaperSize = paper;

            Font fonte = new Font("Arial", 12);
            alturaFonte = fonte.GetHeight(e.Graphics);

            LinhaPorPag = e.MarginBounds.Height / alturaFonte;

            //Título
            if(contador == 0)
            {
                Set.IdSetor = int.Parse(cmbSetor.SelectedValue.ToString());
                Set.ConsultarSetor();
                
                linha = "Relatório do Setor " + Set.NomeSetor;
                posicaoVertical = margemSuperior + contador * alturaFonte;
                e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 270, posicaoVertical);
                contador++;
            }

            string Nome = "";
            int ID = 0;
            string Rua = "";
            string Num = "";
            string Bairro = "";

            while((contador <= LinhaPorPag) && (dr.Read()))
            {
                ID = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Rua = dr.GetString(2);
                Num = dr.GetString(3);
                Bairro = dr.GetString(4);

                linha = "Cod.: " + ID.ToString() + " | " + Nome;
                posicaoVertical = margemSuperior + contador * alturaFonte;
                e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                contador++;

                linha = "      " + Rua + ", " + Num + " - " + Bairro;
                posicaoVertical = margemSuperior + contador * alturaFonte;
                e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                contador += 2;

                if (contador > LinhaPorPag)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            cn.Close();
            dr.Close();
        }
    }
}
