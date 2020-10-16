using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Dizimo
{
    class Tradutor
    {
        private int numTradutor;
        private string descricaoTradutor;

        public int NumTradutor { get => numTradutor; set => numTradutor = value; }
        public string DescricaoTradutor { get => descricaoTradutor; set => descricaoTradutor = value; }

        SqlConnection cn = new SqlConnection();
        SqlCommand cd = new SqlCommand();

        public void Conectar()
        {
            string s = "Server=.\\SQLEXPRESS;Database=Dizimo;UID=sa;PWD=123";
            cn.ConnectionString = s;
            cn.Open();
        }
    }
}
