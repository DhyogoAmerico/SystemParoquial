using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Data;

namespace Dizimo
{
    class GrupoParoquial
    {
        private int idGrupo;
        private string nomeGrupo;
        private string cooGrupo;

        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string NomeGrupo { get => nomeGrupo; set => nomeGrupo = value; }
        public string CooGrupo { get => cooGrupo; set => cooGrupo = value; }

        SqlCommand cd = new SqlCommand();
        SqlConnection cn = new SqlConnection();

        public void Conectar()
        {
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=Dizimo;UID=sa;PWD=123";
            cn.Open();
        }

        public void IncluirGrupo()
        {
            Conectar();
            string sql = "";
            sql = "Insert into GrupoParoquial (NomeGrupo,CooGrupo) values ('" + NomeGrupo + "','" + CooGrupo + "')";
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();            
        }
        public void AlterarGrupo()
        {
            Conectar();
            string sql = "Update GrupoParoquial set NomeGrupo = '" + NomeGrupo + "', CooGrupo = '" + CooGrupo + "' where idGrupo = " + IdGrupo.ToString();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void ExcluirGrupo()
        {
            Conectar();
            string sql = "Delete from GrupoParoquial where idGrupo = " + IdGrupo.ToString();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void ConsultarGrupo()
        {
            Conectar();
            string sql = "Select * from GrupoParoquial where idGrupo = " + IdGrupo.ToString();
            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.Read())
            {
                NomeGrupo = dr["NomeGrupo"].ToString();
                CooGrupo = dr["CooGrupo"].ToString();
            }
            cn.Close();
        }
        public DataSet ListarGrupo()
        {
            Conectar();
            string sql = "Select * from GrupoParoquial where NomeGrupo Like '" + NomeGrupo + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }

        public int UltimoIDGrupo()
        {
            Conectar();
            SqlCommand xd = new SqlCommand("SELECT MAX(idGrupo) FROM GrupoParoquial", cn);
            int ID = (int)xd.ExecuteScalar();
            cn.Close();
            return ID;
        }
    }
}
