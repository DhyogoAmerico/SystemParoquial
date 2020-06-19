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
    public partial class frmIntenções : Form
    {
        public frmIntenções()
        {
            InitializeComponent();
        }

        List<string> louvor = new List<string>();
        List<string> acaoG = new List<string>();
        List<string> saude = new List<string>();
        List<string> falecidos = new List<string>();
        List<string> setDia = new List<string>();

        List<string> NomesNasc = new List<string>();
        List<string> NomesCas = new List<string>();

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();

        int tam = 0;

        public void Conectar()
        {
            string S = "Server =.\\SQLEXPRESS; Database = Dizimo; UID = sa; PWD = 123";
            cn.ConnectionString = S;
            cn.Open();
        }

        private void cmdRefazer_Click(object sender, EventArgs e)
        {
            lstLouvor.Items.Clear();
            louvor.Clear();
            lstAcaoGracas.Items.Clear();
            acaoG.Clear();
            lstSaude.Items.Clear();
            saude.Clear();
            lstFalecidos.Items.Clear();
            falecidos.Clear();
            lst7dia.Items.Clear();
            setDia.Clear();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if ((cbIntenção.SelectedItem != null) && (txtNome.Text != ""))
            {
                switch (cbIntenção.SelectedIndex)
                {
                    //Em louvor
                    case 0:
                        lstLouvor.Items.Add(txtNome.Text);
                        louvor.Add(txtNome.Text);
                        break;
                    //Em ação de graças
                    case 1:
                        lstAcaoGracas.Items.Add(txtNome.Text);
                        acaoG.Add(txtNome.Text);
                        break;
                    //Pela saude
                    case 2:
                        lstSaude.Items.Add(txtNome.Text);
                        saude.Add(txtNome.Text);
                        break;
                    //Pelos falecidos
                    case 3:
                        lstFalecidos.Items.Add(" + " + txtNome.Text);
                        falecidos.Add(" + " + txtNome.Text);
                        break;
                    //7º dia
                    case 4:
                        lst7dia.Items.Add(" + " + txtNome.Text);
                        setDia.Add(" + " + txtNome.Text);
                        break;
                }

                txtNome.Clear();
            }
            else
                MessageBox.Show("Verifique as entradas de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            PaperSize fo = new PaperSize("A4", 795, 1137);
            printDocument1.DocumentName = "Folha de intenção";
            printDocument1.DefaultPageSettings.PaperSize = fo;
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.EndPrint += printDocument1_EndPrint;

            PrintPreviewDialog PPD = new PrintPreviewDialog();
            PPD.Document = printDocument1;
            printDialog1.Document = printDocument1;

            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                PPD.ShowDialog();                
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //Conectar();
            NomesNasc.Clear();
            NomesCas.Clear();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Configurações da página
            PaperSize folha = new PaperSize("A4", 795, 1137);
            e.PageSettings.PaperSize = folha;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsqueda = 20;
            float margemSuperior = 17;
            float alturaFonte = 0;
            string linha = "";
            float LinhaPorPag = 0;
            int MargemInferior = e.MarginBounds.Bottom;
            int MargemDireita = e.MarginBounds.Right;
            Pen P = new Pen(Color.Black,1);

            Font fonte = new Font("Century Gothic", 10);
            alturaFonte = fonte.GetHeight(e.Graphics);
            LinhaPorPag = e.MarginBounds.Height / alturaFonte;
            Font tst = new Font("Century Gothic", 10, FontStyle.Bold); //Fonte em negrito
            string date = "";
            //CABEÇALHO
            if (rdb19.Checked)
                date = " às 19h";
            else if (rdb09.Checked)
                date = " às 09h";
            else
            {
                MessageBox.Show("Selecione a hora da celebração!", "Horário da Celebração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

            linha = dateTimePicker1.Text + date;
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, 300, posicaoVertical);
            contador += 1;

            linha = "Animador: ";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, 40, posicaoVertical);

            linha = "Louvado seja Nosso Senhor Jesus Cristo!";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, 110, posicaoVertical);
            contador += 1;

            linha = "Povo: ";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, 40, posicaoVertical);

            linha = "Para sempre seja louvado.";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, 77, posicaoVertical);
            contador += 1;

            linha = "Animador: ";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, 40, posicaoVertical);

            linha = "Nesta Celebração Eucarística, confiamos ao Senhor Deus as seguintes intenções:";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, 110, posicaoVertical);

            linha = "_____________________________________________________________________________________________________________";
            posicaoVertical = 20 + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 2;

            e.Graphics.DrawLine(P, 408, 1117, 408, 86);
            //INÍCIO DO CORPO DA PÁGINA
            linha = "Por todos os Dizimistas; ";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;

            linha = "Por todos os sócios da Campanha Paroquial de ";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            linha = "Nossa Senhora Aparecida.";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 2;
            //EM AÇÃO DE GRAÇAS
            linha = "Em ação de graças: ";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            foreach(string item in acaoG)
            {
                if (item.Length > 52) //Quebra de linha
                {
                    linha = item;
                    tam = ConsEspaco(linha);

                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha.Substring(0, tam), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;

                    for (int I = tam + 1; I < linha.Length; I += (linha.Length - tam))
                    {
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha.Substring(I, Math.Min((linha.Length - tam), linha.Length - I)), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 1;
                    }
                }
                else
                {
                    linha = item;
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;
                }
            }
            contador += 2;
            //EM LOUVOR
            linha = "Em Louvor: ";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            linha = "Nossa Senhora da Conceição Aparecida";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            linha = "Santa Teresa de Calcutá";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            foreach(string item in louvor)
            {
                if (item.Length > 52) //Quebra de linha
                {
                    linha = item;
                    tam = ConsEspaco(linha);

                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha.Substring(0, tam), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;

                    for (int I = tam + 1; I < linha.Length; I += (linha.Length - tam))
                    {
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha.Substring(I, Math.Min((linha.Length - tam), linha.Length - I)), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 1;
                    }
                }
                else
                {
                    linha = item;
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;
                }
            }
            contador += 2;
            //PELO ANIVERSÁRIO NATALICIO
            linha = "Pelo Aniversário Natalicio de: ";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            NomesNasc = Nascimento();
            tam = 0;
            foreach (string item in NomesNasc)
            {
                if (item.Length > 52) //Quebra de linha
                {
                    linha = item;
                    tam = ConsEspaco(linha);

                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha.Substring(0, tam), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;

                    for (int I = tam + 1; I < linha.Length; I += (linha.Length - tam))
                    {
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha.Substring(I, Math.Min((linha.Length - tam), linha.Length - I)), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 1;
                    }
                }
                else
                {
                    linha = item;
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;
                }
            }
            contador += 8;
            //PELO ANIVERSARIO DE MATRIMONIO
            linha = "Pelo Aniversário de Matrimônio:";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            NomesCas = Casamento();
            tam = 0;
            foreach (string item in NomesCas)
            {
                if (item.Length > 52) //Quebra de linha
                {
                    linha = item;
                    tam = ConsEspaco(linha);

                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha.Substring(0,tam), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;

                    for (int I = tam+1; I < linha.Length; I += (linha.Length - tam))
                    {
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha.Substring(I, Math.Min((linha.Length - tam), linha.Length - I)), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 1;
                    }
                }
                else
                {
                    linha = item;
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;
                }
                
            }
            contador += 10;
            //PELA SAÚDE
            linha = "Pela saúde de:";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            foreach(string item in saude)
            {
                if (item.Length > 52) //Quebra de linha
                {
                    linha = item;
                    tam = ConsEspaco(linha);

                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha.Substring(0, tam), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;

                    for (int I = tam + 1; I < linha.Length; I += (linha.Length - tam))
                    {
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha.Substring(I, Math.Min((linha.Length - tam), linha.Length - I)), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 1;
                    }
                }
                else
                {
                    linha = item;
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;
                }
            }
            contador = 5;
            margemEsqueda = 413;

            //PELOS FALECIDOS 
            linha = "Pelos falecidos:";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            linha = " + Dom Diógenes Silva Mattes";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            linha = " + Pe. Wânius da Costa Monteiro";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            linha = " + Pe. Jaimes Esteves";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 1;
            foreach (string item in falecidos)
            {
                if (item.Length > 52) //Quebra de linha
                {
                    linha = item;
                    tam = ConsEspaco(linha);

                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha.Substring(0, tam), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;

                    for (int I = tam + 1; I < linha.Length; I += (linha.Length - tam))
                    {
                        posicaoVertical = margemSuperior + contador * alturaFonte;
                        e.Graphics.DrawString(linha.Substring(I, Math.Min((linha.Length - tam), linha.Length - I)), fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                        contador += 1;
                    }
                }
                else
                {
                    linha = item;
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;
                }
            }
            if (falecidos.Count <= 5)
                contador += 30;
            else if (falecidos.Count <= 10)
                contador += 25;
            else if (falecidos.Count <=20)
                contador += 15;

            //7º DIA DE FALECIMENTO
            linha = "7º dia de falecimento: ";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, tst, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 2;
            fonte = new Font ("Century Gothic", 20,FontStyle.Bold);

            //Quebra de Linha 
            foreach (string item in setDia)
            {
                linha = item;
                char[] nom = linha.ToCharArray();
                int aux = 0;
                tam = 0;
                if (linha.Length > 25)
                {
                    tam = Contagem7dias(linha);
                    posicaoVertical = margemSuperior + contador * alturaFonte + 20 * (aux + 1);
                    e.Graphics.DrawString(linha.Substring(0,tam), fonte, Brushes.Black, 410, posicaoVertical);
                    contador += 1;

                    for(int I = tam; I < linha.Length; I += (linha.Length - tam))
                    {
                        posicaoVertical = margemSuperior + contador * alturaFonte + 33;
                        e.Graphics.DrawString(linha.Substring(I, Math.Min((linha.Length - tam), linha.Length - I)), fonte, Brushes.Black, 410, posicaoVertical);
                    }
                }
                else
                {
                    posicaoVertical = margemSuperior + contador * alturaFonte + 20 * (aux + 1);
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, 410, posicaoVertical);
                    contador += 1;
                }
                aux += 1;
                contador += 3;
            }
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private List<string> Nascimento()
        {
            Conectar();
            SqlDataReader dr = null;
            string sql = "";
            int di = monthCalendar1.SelectionStart.Day;
            int df = monthCalendar1.SelectionEnd.Day;
            int mm = monthCalendar1.SelectionStart.Month;
            List<string> X = new List<string>();

            //Dados dos aniversariantes natalícios
            //NomesNasc = null;
            if (di < df)
            {
                sql = "Select Nome_Dizimista from Dizimista4 where day(DataN_Dizimista) >= " + monthCalendar1.SelectionStart.ToString("dd");
                sql += " and day(DataN_Dizimista) <= " + monthCalendar1.SelectionEnd.ToString("dd");
                sql += " and MONTH(DataN_Dizimista) = " + monthCalendar1.SelectionStart.ToString("MM");
                cm.Connection = cn;
                cm.CommandText = sql;

                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    X.Add(dr.GetString(0));
                }
                dr.Close();
            }
            else if (di > df)
            {
                if ((mm == 4) || (mm == 6) || (mm == 9) || (mm == 11)) //testar com 31 no dia sem essa condição
                {
                    sql = "Select Nome_Dizimista from Dizimista4 where day(DataN_Dizimista) >= " + monthCalendar1.SelectionStart.ToString("dd");
                    sql += " and day(DataN_Dizimista) <= 30";
                    sql += " and MONTH(DataN_Dizimista) = " + monthCalendar1.SelectionStart.ToString("MM");
                    cm.Connection = cn;
                    cm.CommandText = sql;

                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        X.Add(dr.GetString(0));
                    }
                    dr.Close();

                    sql = "Select Nome_Dizimista from Dizimista4 where day(DataN_Dizimista) >= 1";
                    sql += " and day(DataN_Dizimista) <= " + monthCalendar1.SelectionEnd.ToString("dd");
                    sql += " and MONTH(DataN_Dizimista) = " + (mm + 1).ToString();
                    cm.Connection = cn;
                    cm.CommandText = sql;

                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        X.Add(dr.GetString(0));
                    }
                    dr.Close();
                }
            }
            cn.Close();
            return X;
        }

        private List<string> Casamento()
        {
            Conectar();
            SqlDataReader dr = null;
            string sql = "";
            int di = monthCalendar1.SelectionStart.Day;
            int df = monthCalendar1.SelectionEnd.Day;
            int mm = monthCalendar1.SelectionStart.Month;
            List<string> Diz = new List<string>();
            List<string> X = new List<string>();

            //Dados dos aniversariantes de casamento 
            //NomesCas = null;
            if (di < df)
            {
                sql = "Select Nome_Dizimista,Conjuge_Diz from Dizimista4 where day(DataCas_Dizimista) >= " + monthCalendar1.SelectionStart.ToString("dd");
                sql += " and day(DataCas_Dizimista) <= " + monthCalendar1.SelectionEnd.ToString("dd");
                sql += " and MONTH(DataCas_Dizimista) = " + monthCalendar1.SelectionStart.ToString("MM");
                cm.Connection = cn;
                cm.CommandText = sql;

                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    bool aux = false;
                    if(Diz.Count > 0)
                    {
                        foreach (string Y in Diz)
                        {
                            if (Y == dr.GetString(1))
                            {
                                aux = true;
                                break;
                            }
                        }
                    }
                    if (aux == false)
                    {
                        X.Add(dr.GetString(0) + " e " + dr.GetString(1));
                        Diz.Add(dr.GetString(0));
                    }
                }
                dr.Close();
            }
            else if (di > df)
            {
                if ((mm == 4) || (mm == 6) || (mm == 9) || (mm == 11)) //testar com 31 no dia sem essa condição
                {
                    sql = "Select Nome_Dizimista,Conjuge_Diz from Dizimista4 where day(DataCas_Dizimista) >= " + monthCalendar1.SelectionStart.ToString("dd");
                    sql += " and day(DataCas_Dizimista) <= 30";
                    sql += " and MONTH(DataCas_Dizimista) = " + monthCalendar1.SelectionStart.ToString("MM");
                    cm.Connection = cn;
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        bool aux = false;
                        if (Diz.Count > 0)
                        {
                            foreach (string Y in Diz)
                            {
                                if (Y == dr.GetString(1))
                                {
                                    aux = true;
                                    break;
                                }
                            }
                        }
                        if (aux == false)
                        {
                            X.Add(dr.GetString(0) + " e " + dr.GetString(1));
                            Diz.Add(dr.GetString(0));
                        }
                    }
                    dr.Close();

                    sql = "Select Nome_Dizimista,Conjuge_Diz from Dizimista4 where day(DataCas_Dizimista) >= 1";
                    sql += " and day(DataCas_Dizimista) <= " + monthCalendar1.SelectionEnd.ToString("dd");
                    sql += " and MONTH(DataCas_Dizimista) = " + (mm + 1).ToString();
                    cm.Connection = cn;
                    cm.CommandText = sql;

                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        bool aux = false;
                        if (Diz.Count > 0)
                        {
                            foreach (string Y in Diz)
                            {
                                if (Y == dr.GetString(1))
                                {
                                    aux = true;
                                    break;
                                }
                            }
                        }
                        if (aux == false)
                        {
                            X.Add(dr.GetString(0) + " e " + dr.GetString(1));
                            Diz.Add(dr.GetString(0));
                        }
                    }
                    dr.Close();
                }
            }
            cn.Close();
            return X;
        }

        // Duplo clique sobre o item o remove do List Box
        private void lstFalecidos_DoubleClick(object sender, EventArgs e)
        {
            int X = lstFalecidos.SelectedIndex;
            string inte = lstFalecidos.SelectedItem.ToString();
            lstFalecidos.Items.Remove(lstFalecidos.SelectedItem);
            for (int I = 0; I < falecidos.Count; I++)
            {
                if (falecidos[I] == inte)
                {
                    falecidos.RemoveRange(I, 1);
                }
            }
        }

        private void lstLouvor_DoubleClick(object sender, EventArgs e)
        {
            int X = lstLouvor.SelectedIndex;
            string inte = lstLouvor.SelectedItem.ToString();
            lstLouvor.Items.Remove(lstLouvor.SelectedItem);
            for (int I = 0; I < louvor.Count; I++)
            {
                if (louvor[I] == inte)
                {
                    louvor.RemoveRange(I, 1);
                }
            }
        }

        private void lstAcaoGracas_DoubleClick(object sender, EventArgs e)
        {
            int X = lstAcaoGracas.SelectedIndex;
            string inte = lstAcaoGracas.SelectedItem.ToString();
            lstAcaoGracas.Items.Remove(lstAcaoGracas.SelectedItem);
            for (int I = 0; I < acaoG.Count; I++)
            {
                if (acaoG[I] == inte)
                {
                    acaoG.RemoveRange(I, 1);
                }
            }
        }

        private void lstSaude_DoubleClick(object sender, EventArgs e)
        {
            int X = lstSaude.SelectedIndex;
            string inte = lstSaude.SelectedItem.ToString();
            lstSaude.Items.Remove(lstSaude.SelectedItem);
            for (int I = 0; I < saude.Count; I++)
            {
                if (saude[I] == inte)
                {
                    saude.RemoveRange(I, 1);
                }
            }
        }

        private void lst7dia_DoubleClick(object sender, EventArgs e)
        {
            int X = lst7dia.SelectedIndex;
            string inte = lst7dia.SelectedItem.ToString();
            lst7dia.Items.Remove(lst7dia.SelectedItem);
            for (int I = 0; I < setDia.Count; I++)
            {
                if (setDia[I] == inte)
                {
                    setDia.RemoveRange(I, 1);
                }
            }
        }

        private int Contagem7dias(string n)
        {
            // Procura espaço antes do fim da margem direita, para fazer a quebra de linha
            char[] nome = n.ToCharArray();
            for (int I = 15; I < 25; I++)
            {
                if (nome[I] == ' ')
                {
                    if ((nome[I + 3] == ' ') && (I + 3 < 25))//procura se cabe a preposição (de ou da) na mesma linha
                        return (I + 3);
                    else
                        return I;
                }
            }
            return 0;
        }

        private int ConsEspaco(string n)
        {
            //Procura espaço antes do fim da margem direita, para fazer a quebra de linha
            char[] nome = n.ToCharArray();
            for (int I = 43; I < 53; I++)
            {
                if(nome[I] == ' ')
                {
                    if ((nome[I + 3] == ' ') || (nome[I + 2] == ' ') && (I + 3 < 53))//procura se cabe a preposição (de ou da) na mesma linha
                        return (I + 3);
                    else
                        return I;
                }
            }
            return 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
