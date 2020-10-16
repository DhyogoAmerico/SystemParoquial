using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dizimo
{
    class RecibosEntrada
    {
        private int numRecibo;
        private int mesRef;
        private int anoRef;
        private string nome_recibo;
        private string cpf_recibo;
        private double valor_recibo;
        private string data_pagamento;
        private string data_recibo;
        private string local_pagamento;
        private int tradutor;

        public int NumRecibo { get => numRecibo; set => numRecibo = value; }
        public int MesRef { get => mesRef; set => mesRef = value; }
        public int AnoRef { get => anoRef; set => anoRef = value; }
        public string Nome_recibo { get => nome_recibo; set => nome_recibo = value; }
        public double Valor_recibo { get => valor_recibo; set => valor_recibo = value; }
        public string Data_pagamento { get => data_pagamento; set => data_pagamento = value; }
        public string Data_recibo { get => data_recibo; set => data_recibo = value; }
        public string Local_pagamento { get => local_pagamento; set => local_pagamento = value; }
        public int Tradutor { get => tradutor; set => tradutor = value; }
        public string Cpf_recibo { get => cpf_recibo; set => cpf_recibo = value; }

        SqlConnection cn = new SqlConnection();
        SqlCommand cd = new SqlCommand();
                

        public void Conectar()
        {
            string s = "Server=.\\SQLEXPRESS;Database=Dizimo;UID=sa;PWD=123";
            cn.ConnectionString = s;
            cn.Open();
        }

        public void IncluirRecibo()
        {
            Conectar();
            string sql = "Insert into ReciboEntrada (NumRecibo,Mes_ref,Ano_ref,Nome_recibo,CPF_recibo,Valor_recibo,Data_pagamento,Data_recibo,Local_pagamento,Tradutor_pagamento)";
            sql += $" values ('{NumRecibo}','{MesRef}','{AnoRef}','{Nome_recibo}','{Cpf_recibo}','{Valor_recibo}','{Data_pagamento}','{Data_recibo}'";
            sql += $",'{Local_pagamento}','{Tradutor}')";

            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public void RemoverRecibo()
        {
            Conectar();
            string sql = $"Delete from ReciboEntrada where Num_recibo = {NumRecibo} and Ano_ref = {AnoRef}";
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public void AlterarRecibo()
        {
            Conectar();
            string sql = $"Update ReciboEntrada set Mes_ref = '{MesRef}', Ano_ref = '{AnoRef}',Nome_recibo = '{Nome_recibo}',CPF_recibo = '{Cpf_recibo}',";
            sql += $"Valor_recibo = '{Valor_recibo}', Data_pagamento = '{Data_pagamento}',Data_recibo = '{Data_recibo}', Local_pagamento = '{Local_pagamento}',";
            sql += $"Tradutor_pagamento = '{Tradutor}' where NumRecibo = {NumRecibo} and Ano_ref = {AnoRef}";
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public void ConsultarRecibo(int opcao)
        {
            Conectar();
            string sql = "";
            switch (opcao)
            {
                case 1://Numero do Recibo
                    sql = $"Select * from ReciboEntrada where NumRecibo = {NumRecibo}";
                    break;
                case 2: // Mes de Referencia 
                    sql = $"Select * from ReciboEntrada where Mes_ref = {MesRef}";
                    break;
                case 3: //Valor do Recibo
                    sql = $"Select * from ReciboEntrada where Valor_pagamento = {Valor_recibo}";
                    break;
                case 4: //Nome da pessoa que pagou
                    sql = $"Select * from ReciboEntrada where Nome_recibo = {Nome_recibo}";
                    break;
                case 5: //Tradutor
                    sql = $"Select * from ReciboEntrada where Tradutor_pagamento = {Tradutor}";
                    break;
            }
            
            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.Read())
            {
                NumRecibo = int.Parse(dr["NumRecibo"].ToString());
                MesRef = int.Parse(dr["Mes_ref"].ToString());
                AnoRef = int.Parse(dr["Ano_ref"].ToString());
                Nome_recibo = dr["Nome_recibo"].ToString();
                Cpf_recibo = dr["CPF_recibo"].ToString();
                Valor_recibo = double.Parse(dr["Valor_recibo"].ToString());
                Data_pagamento = dr["Data_pagamento"].ToString();
                Data_recibo = dr["Data_recibo"].ToString();
                Local_pagamento = dr["Local_pagamento"].ToString();
                Tradutor = int.Parse(dr["Tradutor_pagamento"].ToString());
            }
            cn.Close();
        }
    }
}
