using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dizimo
{
    class Setor
    {
        private int idSetor;
        private string nomeSetor;

        public int IdSetor { get => idSetor; set => idSetor = value; }
        public string NomeSetor { get => nomeSetor; set => nomeSetor = value; }

        SqlConnection cn = new SqlConnection();
        SqlCommand cd = new SqlCommand();

        public void Conectar()
        {
            string s = "Server=.\\SQLEXPRESS;Database=Dizimo;UID=sa;PWD=123";
            cn.ConnectionString = s;
            cn.Open();
        }

        public DataSet ListarSetor()
        {
            // Retornar no dataSet os campos da Receita de acordo com o campo descrição usando LIKE na SQL
            Conectar();
            string sql = "";
            sql += "Select * from Setor ";
            sql += "where NomeSetor Like '" + NomeSetor + "%'";

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }

        public void ConsultarSetor()
        {
            Conectar();
            string Sql = "";
            Sql = "Select * from Setor where idSetor = " + IdSetor.ToString();
            cd.Connection = cn;
            cd.CommandText = Sql;
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.Read())
            {
                NomeSetor = dr["NomeSetor"].ToString();                
            }
            cn.Close();
        }

        public DataSet ListarQuantPorSetor()
        {
            Conectar();

            string sql = "SELECT IdDizimista,Nome_Dizimista, Rua_Dizimista, Num_Dizimista, Bairro_Dizimista FROM Dizimista4 ";
            sql += "INNER JOIN Setor ON Dizimista4.idSetor = Setor.idSetor ";
            sql += "WHERE Dizimista4.idSetor = " + IdSetor.ToString();

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }

        public int ListarCountSetor (int id)
        {
            Conectar();
            int total = 0;
            string sql = "SELECT COUNT(Dizimista4.idSetor) AS Total FROM Dizimista4 ";
            sql += "WHERE Dizimista4.idSetor = " + id.ToString();

            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.Read())
            {
                total = (int)dr["Total"];

            }
            cn.Close();
            return total;
        }
    }
}
