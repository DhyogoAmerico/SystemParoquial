using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;
using System.Data;

namespace Dizimo
{
    class Agenda
    {
        private int idContato;
        private string nomeContato;
        private string tel1Contato;
        private string tel2Contato;
        private string tel3Contato;
        private string descricaoContato;
        private int idGrupo;

        public int IdContato { get => idContato; set => idContato = value; }
        public string NomeContato { get => nomeContato; set => nomeContato = value; }
        public string Tel1Contato { get => tel1Contato; set => tel1Contato = value; }
        public string Tel2Contato { get => tel2Contato; set => tel2Contato = value; }
        public string Tel3Contato { get => tel3Contato; set => tel3Contato = value; }
        public string DescricaoContato { get => descricaoContato; set => descricaoContato = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }

        SqlCommand cd = new SqlCommand();
        SqlConnection cn = new SqlConnection();

        public void Conectar()
        {
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=Dizimo;UID=sa;PWD=123";
            cn.Open();
        }

        public void IncluirContato()
        {
            Conectar();
            string sql = "Insert into Agenda (NomeContato,Tel1Contato,Tel2Contato,Tel3Contato,DescricaoContato,idGrupo) ";
            sql += "values ('" + NomeContato + "','" + Tel1Contato + "','" + Tel2Contato + "','";
            sql += Tel3Contato + "','" + DescricaoContato + "','" + idGrupo.ToString() + "')";
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void AlterarContato()
        {
            Conectar();
            string sql = "Update Agenda set NomeContato = '" + NomeContato + "',Tel1Contato = '" + Tel1Contato + "',Tel2Contato = '" + Tel2Contato;
            sql += "',Tel3Contato = '" + Tel3Contato + "',DescricaoContato = '" + DescricaoContato + "',idGrupo = '" + IdGrupo.ToString();
            sql += "' where idContato = " + idContato.ToString();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void ExcluirContato()
        {
            Conectar();
            string sql = "Delete from Agenda where idContato = " + IdContato.ToString();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void ConsultarContato()
        {
            Conectar();
            string sql = "Select * from Agenda where idContato = " + idContato.ToString();
            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.Read())
            {
                NomeContato = dr["NomeContato"].ToString();
                Tel1Contato = dr["Tel1Contato"].ToString();
                Tel2Contato = dr["Tel2Contato"].ToString();
                Tel3Contato = dr["Tel3Contato"].ToString();
                DescricaoContato = dr["DescricaoContato"].ToString();
                IdGrupo = int.Parse(dr["idGrupo"].ToString());
            }
            cn.Close();
        }

        public DataSet ListarContato()
        {
            Conectar();
            string sql = "Select idContato,NomeContato from Agenda where NomeContato Like '" + NomeContato + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }
        public DataSet ListarPorGrupo()
        {
            Conectar();
            string sql = "Select NomeContato from Agenda where idGrupo = " + IdGrupo.ToString();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }
    }
}
