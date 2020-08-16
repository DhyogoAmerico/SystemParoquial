using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dizimo
{
    class Dizimista
    {
        private int idDizimista;
        private string nome_Dizimista;
        private string cpf_Dizimista;
        private string dataN_Dizimista;
        private string conjuge_Diz;  
        private string dataCas_Dizimista;
        private string rua_Dizimista;
        private string num_Dimista;
        private string bairro_dizimista;
        private int setor_Dizimista;
        private string tel_dizimista;
        private float valor_dizimista;

        public int IdDizimista { get => idDizimista; set => idDizimista = value; }
        public string Nome_Dizimista { get => nome_Dizimista; set => nome_Dizimista = value; }
        public string Cpf_Dizimista { get => cpf_Dizimista; set => cpf_Dizimista = value; }
        public string DataN_Dizimista { get => dataN_Dizimista; set => dataN_Dizimista = value; }
        public string Conjuge_Diz { get => conjuge_Diz; set => conjuge_Diz = value; }
        public string DataCas_Dizimista { get => dataCas_Dizimista; set => dataCas_Dizimista = value; }
        public string Rua_Dizimista { get => rua_Dizimista; set => rua_Dizimista = value; }
        public string Num_Dimista { get => num_Dimista; set => num_Dimista = value; }
        public string Bairro_dizimista { get => bairro_dizimista; set => bairro_dizimista = value; }
        public int Setor_Dizimista { get => setor_Dizimista; set => setor_Dizimista = value; }
        public string Tel_dizimista { get => tel_dizimista; set => tel_dizimista = value; }
        public float Valor_dizimista { get => valor_dizimista; set => valor_dizimista = value; }

        SqlConnection cn = new SqlConnection();
        SqlCommand cd = new SqlCommand();

        public void Conectar()
        {
            string s = "Server=.\\SQLEXPRESS;Database=Dizimo;UID=sa;PWD=123";
            cn.ConnectionString = s;
            cn.Open();
        }
        public void IncluirDiz()
        {
            Conectar();
            string sql = "";
            sql = "Insert into Dizimista4 (idDizimista,Nome_Dizimista,CPF_Dizimista,DataN_Dizimista,Conjuge_Diz,DataCas_Dizimista,";
            sql += $"Rua_Dizimista,Num_Dizimista,Bairro_Dizimista,Tel_Dizimista,Valor_Dizimista,idSetor) values ('{IdDizimista}','{Nome_Dizimista}','{Cpf_Dizimista}'";
            sql += $",'{DataN_Dizimista}','{Conjuge_Diz}','{DataCas_Dizimista}','{Rua_Dizimista} '";
            sql += $",'{Num_Dimista}','{Bairro_dizimista}','{Tel_dizimista}','{Valor_dizimista}','{Setor_Dizimista}')";
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public void AlteraDizimista()
        {
            Conectar();
            string sql = $"Update Dizimista4 set Nome_Dizimista = '{Nome_Dizimista}', CPF_Dizimista = '{Cpf_Dizimista}',";
            sql += $" DataN_Dizimista = '{DataN_Dizimista}', Conjuge_Diz = '{Conjuge_Diz}', DataCas_Dizimista = '{DataCas_Dizimista}',";
            sql += $" Rua_Dizimista = '{Rua_Dizimista}', Num_Dizimista = '{Num_Dimista}', Bairro_Dizimista = '{Bairro_dizimista}',";
            sql += $" Tel_Dizimista = '{Tel_dizimista}', Valor_Dizimista = '{Valor_dizimista}', idSetor = '{Setor_Dizimista}'";
            sql += $" where idDizimista = {IdDizimista}";
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }
        
        public void ExcluirDizimista()
        {
            Conectar();
            string sql = $"Delete from Dizimista4 where idDizimista = {IdDizimista}";
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();

            cn.Close();
        }

        public void ConsultarDizimista()
        {
            Conectar();
            string sql = $"Select * from Dizimista4 where idDizimista = {IdDizimista}";
            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.Read())
            {
                Nome_Dizimista = dr["Nome_Dizimista"].ToString();
                Cpf_Dizimista = dr["CPF_Dizimista"].ToString();
                DataN_Dizimista = dr["DataN_Dizimista"].ToString();
                Conjuge_Diz = dr["Conjuge_Diz"].ToString();
                DataCas_Dizimista = dr["DataCas_Dizimista"].ToString();
                Rua_Dizimista = dr["Rua_Dizimista"].ToString();
                Num_Dimista = dr["Num_Dizimista"].ToString();
                Bairro_dizimista = dr["Bairro_Dizimista"].ToString();
                Tel_dizimista = dr["Tel_Dizimista"].ToString();
                Valor_dizimista = float.Parse(dr["Valor_Dizimista"].ToString());
                Setor_Dizimista = int.Parse(dr["idSetor"].ToString());
            }
            cn.Close();
        }

        public DataSet ListarDizimista()
        {
            Conectar();
            string sql = $"Select * from Dizimista4 where Nome_Dizimista Like '{Nome_Dizimista}%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }

        public int ConsultID() //Consulta ultimo ID inserido
        {
            Conectar();

            SqlCommand xd = new SqlCommand("SELECT MAX(idDizimista) FROM Dizimista4",cn);
            int ID = (int)xd.ExecuteScalar();
            cn.Close();
            return ID;
        }

        public DataSet ListaPorDN(int din, int dfim, int mes) //Lista pela data de nascimento
        {
            Conectar();
            string sql = "Select idDizimista,Nome_Dizimista,Rua_Dizimista, Num_Dizimista, Bairro_Dizimista from Dizimista4 ";
            sql += $"where day(DataN_Dizimista) >= {din} and day(DataN_Dizimista) <= {dfim} and MONTH(DataN_Dizimista) = {mes}";

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            
            da.Fill(ds);
            cn.Close();
            return ds;
        }

        public DataSet ListaPorDCas(int din, int dfim, int mes) //Lista Pela data de Casamento
        {
            Conectar();
            string sql = "Select idDizimista,Nome_Dizimista,Conjuge_Diz,Rua_Dizimista, Num_Dizimista, Bairro_Dizimista from Dizimista4 ";
            sql += $"where day(DataCas_Dizimista) >= {din} and day(DataCas_Dizimista) <= {dfim} and MONTH(DataCas_Dizimista) = {mes}";

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }
    }
}
