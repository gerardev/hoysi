using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace delimerced.Clases
{
    public class conexion
    {

        public OleDbConnection con;
        public OleDbConnection newcon()
        {
            string ds = "C:/delimerced/delimerced.mdb";
            string stringConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ds;
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = stringConexion;
            return con;
        }
    }
}
