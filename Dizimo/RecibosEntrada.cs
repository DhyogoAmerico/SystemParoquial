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
        private int idDizimista;
        private string local;
        private double valor;
        private string data;

        public int IdDizimista { get => idDizimista; set => idDizimista = value; }
        public string Local { get => local; set => local = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Data { get => data; set => data = value; }

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
            string sql = "Insert into ReciboEntrada (idDizimista,Local,Valor,Data) values ('" + IdDizimista.ToString() + "','" + Local + "',";
            sql += "'" + Valor.ToString() + "','" + Data + "')";
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public void RemoverRecibo()
        {
            Conectar();
            string sql = "Delete from ReciboEntrada where idDizimsita = " + IdDizimista.ToString();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public void AlterarRecibo()
        {
            Conectar();
            string sql = "Update ReciboEntrada set Local = '" + Local + "', Valor = '" + Valor.ToString() + "', Data = '" + Data + "' where idDizimista = " + IdDizimista.ToString();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public void ConsultarRecibo()
        {
            Conectar();
            string sql = "Select * from ReciboEntrada where idDizimista = " + IdDizimista.ToString();
            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.Read())
            {
                Local = dr["Local"].ToString();
                Valor = double.Parse(dr["Valor"].ToString());
            }
            cn.Close();
        }
    }
}
