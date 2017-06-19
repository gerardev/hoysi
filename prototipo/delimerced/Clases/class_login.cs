using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace delimerced.Clases
{
    class class_login
    {
        public bool log(string user, string pass)
        {
            try
            {
                OleDbConnection cn = new conexion().newcon();
                cn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = cn;
                command.CommandText = "select * from usuarios where usuario = '" + user + "' and pass = '" + pass + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
    
}
