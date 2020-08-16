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
    public partial class frmFiltroDizimista : Form
    {
        public frmFiltroDizimista()
        {
            InitializeComponent();
        }

        public int Dn = 0, Dc = 0;
        Dizimista Diz = new Dizimista();
        int sinal = 0;
        SqlDataReader dr = null;
        List<string> auxNome = null;
        bool flagCasais = false;

        private void FormatarGrid()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows[0].Selected = true;
        }

        SqlConnection cn = new SqlConnection();
        SqlCommand cd = new SqlCommand();

        public void Conectar()//Teste
        {
            string s = "Server=.\\SQLEXPRESS;Database=Dizimo;UID=sa;PWD=123";
            cn.ConnectionString = s;
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e) //cmdPesquisar
        {
            string dinc = monthCalendar1.SelectionStart.ToString("dd");
            string dfim = monthCalendar1.SelectionEnd.ToString("dd");
            string Mes = monthCalendar1.SelectionStart.ToString("MM");
            if (Dn == 1)
            {
                dataGridView1.DataSource = Diz.ListaPorDN(int.Parse(dinc), int.Parse(dfim), int.Parse(Mes)).Tables[0];
            }
            else if (Dc == 1)
            {
                dataGridView1.DataSource = Diz.ListaPorDCas(int.Parse(dinc), int.Parse(dfim), int.Parse(Mes)).Tables[0];
            }
        }

        private void cmdImprimirListaNomes_Click(object sender, EventArgs e)
        {
            sinal = 1;
            PrintDocument PdN = new PrintDocument();
            PrintDocument PdC = new PrintDocument();
            PrintPreviewDialog PPD = new PrintPreviewDialog();

            //cria o objeto de impressão
            printDialog1.AllowSomePages = false;
            printDialog1.ShowHelp = false;
            if (Dn == 1)
            {
                PdN.DocumentName = "Relátorios";

                PdN.BeginPrint += printDocument1_BeginPrint;
                PdN.PrintPage += printDocument1_PrintPage;
                PdN.EndPrint += printDocument1_EndPrint;

                PPD.Document = PdN;
                printDialog1.Document = PdN;
                DialogResult R = printDialog1.ShowDialog();
                if (R == DialogResult.OK)
                {
                    PPD.ShowDialog();
                }
            }
            else if (Dc == 1)
            {
                //Pd.PrintPage += ImprimirCas;
                PdC.DocumentName = "Relátorio de Casamento";

                PdC.BeginPrint += printDocument2_BeginPrint;
                PdC.PrintPage += printDocument2_PrintPage;
                PdC.EndPrint += printDocument2_EndPrint;

                PPD.Document = PdC;
                printDialog1.Document = PdC;
                DialogResult R = printDialog1.ShowDialog();
                if (R == DialogResult.OK)
                {
                    PPD.ShowDialog();
                }
            }
            sinal = 0;
        }

        private void cmdImprimirComEnd_Click(object sender, EventArgs e)
        {
            sinal = 0;
            PrintDocument PdN = new PrintDocument();
            PrintDocument PdC = new PrintDocument(); 
            PrintPreviewDialog PPD = new PrintPreviewDialog();

            //cria o objeto de impressão
            printDialog1.AllowSomePages = false;
            printDialog1.ShowHelp = false;
            if (Dn == 1)
            {
                //Pd.PrintPage += ImprimirAniv;
                PdN.DocumentName = "Relátorios";

                PdN.BeginPrint += printDocument1_BeginPrint;
                PdN.PrintPage += printDocument1_PrintPage;
                PdN.EndPrint += printDocument1_EndPrint;

                PPD.Document = PdN;
                printDialog1.Document = PdN;
                DialogResult R = printDialog1.ShowDialog();
                if (R == DialogResult.OK)
                {
                    PPD.ShowDialog();
                }
            }
            else if (Dc == 1)
            {
                //Pd.PrintPage += ImprimirCas;
                PdC.DocumentName = "Relátorio de Casamento";

                PdC.BeginPrint += printDocument2_BeginPrint;
                PdC.PrintPage += printDocument2_PrintPage;
                PdC.EndPrint += printDocument2_EndPrint;

                PPD.Document = PdC;
                printDialog1.Document = PdC;
                DialogResult R = printDialog1.ShowDialog();
                if (R == DialogResult.OK)
                {
                    PPD.ShowDialog();
                }
            }

        }

        private void frmFiltroDizimista_Load(object sender, EventArgs e)
        {
            if (Dn == 1)
            {
                lblCalendar.Text = "Data de Nascimento: ";
                lblNomeForm.Text = "Filtrar por Data de Nascimento";

            }
            else if (Dc == 1)
            {
                lblCalendar.Text = "Data de Casamento: ";
                lblNomeForm.Text = "Filtrar por Data de Casamento";
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e) //Data de Nascimento
        {
            Conectar();
            string sql = "Select idDizimista,Nome_Dizimista,Rua_Dizimista, Num_Dizimista, Bairro_Dizimista from Dizimista4 ";
            sql += "where day(DataN_Dizimista) >= " + monthCalendar1.SelectionStart.ToString("dd") + " and day(DataN_Dizimista) <= " + monthCalendar1.SelectionEnd.ToString("dd");
            sql += " and MONTH(DataN_Dizimista) = " + monthCalendar1.SelectionStart.ToString("MM");

            cd.Connection = cn;
            cd.CommandText = sql;

            dr = cd.ExecuteReader();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e) //Data de Nascimento
        {
            //Configurações da página
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsqueda = 20;
            float margemSuperior = 30;
            float alturaFonte = 0;
            string linha = "";
            float LinhaPorPag = 0;
            int MargemInferior = e.MarginBounds.Bottom;
            int MargemDireita = e.MarginBounds.Right;

            PaperSize folha = new PaperSize("A4", 795, 1137);

            Font fonte = new Font("Arial", 14);
            alturaFonte = fonte.GetHeight(e.Graphics);
            LinhaPorPag = e.MarginBounds.Height / alturaFonte;

            string Nome = "";
            string Rua = "";
            string Num = "";
            string Bairro = "";

            if (sinal == 1)
            {
                while ((contador <= LinhaPorPag) && (dr.Read()))
                {
                    Nome = dr.GetString(1);

                    linha = Nome;
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;

                    if (contador > LinhaPorPag)
                        e.HasMorePages = true;
                    else
                        e.HasMorePages = false;
                }
            }
            else if (sinal == 0)
            {
                while ((contador <= LinhaPorPag) && (dr.Read()))
                {
                    Nome = dr.GetString(1);//Nome_Dizimista
                    Rua = dr.GetString(2);//Rua_Dizimista
                    Num = dr.GetString(3);//Num_Dizimista
                    Bairro = dr.GetString(4);//Bairro_Dizimista

                    linha = Nome;
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;

                    linha = Rua + ", " + Num + " - " + Bairro;
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;

                    linha = "Serrania-MG";
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;

                    linha = "37.143-000";
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 3;

                    if (contador > LinhaPorPag)
                        e.HasMorePages = true;
                    else
                        e.HasMorePages = false;
                }
            }
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e) //Data de Nascimento
        {
            dr.Close();
            cn.Close();
        }

        private void printDocument2_BeginPrint(object sender, PrintEventArgs e) //Data de Casamento
        {
            Conectar();
            string sql = "Select idDizimista,Nome_Dizimista,Conjuge_Diz,Rua_Dizimista, Num_Dizimista, Bairro_Dizimista from Dizimista4 ";
            sql += "where day(DataCas_Dizimista) >= " + monthCalendar1.SelectionStart.ToString("dd") + " and day(DataCas_Dizimista) <= " + monthCalendar1.SelectionEnd.ToString("dd");
            sql += " and MONTH(DataCas_Dizimista) = " + monthCalendar1.SelectionStart.ToString("MM");

            cd.Connection = cn;
            cd.CommandText = sql;

            dr = cd.ExecuteReader();
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e) //Data de Casamento
        {
            auxNome = new List<string>();
            //Configurações da página
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsqueda = 20;
            float margemSuperior = 30;
            float alturaFonte = 0;
            string linha = "";
            float LinhaPorPag = 0;
            int MargemInferior = e.MarginBounds.Bottom;
            int MargemDireita = e.MarginBounds.Right;

            PaperSize folha = new PaperSize("A4", 795, 1137);

            Font fonte = new Font("Arial", 14);
            alturaFonte = fonte.GetHeight(e.Graphics);
            LinhaPorPag = e.MarginBounds.Height / alturaFonte;

            string Nome = "";
            string Conj = "";
            string Rua = "";
            string Num = "";
            string Bairro = "";

            if (sinal == 1)
            {
                while ((contador <= LinhaPorPag) && (dr.Read()))
                {
                    Nome = dr.GetString(1);
                    Conj = dr.GetString(2);
                    foreach(string item in auxNome)
                    {
                        if(Nome == item)
                        {
                            flagCasais = true;
                            break;
                        }
                    }
                    if (flagCasais == false)
                    {
                        linha = Nome + " e " + Conj;
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 1;
                        auxNome.Add(Conj);
                    }
                    else
                        flagCasais = false;
                    

                    if (contador > LinhaPorPag)
                        e.HasMorePages = true;
                    else
                        e.HasMorePages = false;
                }
            }
            else if (sinal == 0)
            {
                while ((contador <= LinhaPorPag) && (dr.Read()))
                {
                    Nome = dr.GetString(1);//Nome_Dizimista
                    Rua = dr.GetString(3);//Rua_Dizimista
                    Num = dr.GetString(4);//Num_Dizimista
                    Bairro = dr.GetString(5);//Bairro_Dizimista

                    foreach (string item in auxNome)
                    {
                        if (Nome == item)
                        {
                            flagCasais = true;
                            break;
                        }
                    }
                    if (flagCasais == false)
                    {
                        linha = Nome;
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 1;

                        linha = Rua + ", " + Num + " - " + Bairro;
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 1;

                        linha = "Serrania-MG";
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 1;

                        linha = "37.143-000";
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 3;
                        auxNome.Add(Conj);
                    }
                    else
                        flagCasais = false;

                    

                    if (contador > LinhaPorPag)
                        e.HasMorePages = true;
                    else
                        e.HasMorePages = false;
                }

            }
        }

        private void printDocument2_EndPrint(object sender, PrintEventArgs e) //Data de Casamento 
        {
            dr.Close();
            cn.Close();
        }
    }
}