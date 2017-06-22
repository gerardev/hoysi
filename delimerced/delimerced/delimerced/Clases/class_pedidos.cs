using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace delimerced.Clases
{
    class class_pedidos
    {
        public string crearpedido(string nombre, string dir, string tipo)
        {
            OleDbConnection cn = new conexion().newcon();
            try
            {
                DateTime thisDay = DateTime.Today;
                string fecha = DateTime.Now.ToString("G");
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = cn;
                    command.CommandText = "INSERT INTO pedido (tipo, cliente, direccion) VALUES(?, ?, ?)";
                    command.Parameters.AddWithValue("tipo", tipo);
                    command.Parameters.AddWithValue("cliente", nombre);
                    command.Parameters.AddWithValue("direccion", dir);



                    try
                    {
                        cn.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        if (recordsAffected > 0)
                        {
                            using (OleDbCommand command1 = new OleDbCommand())
                            {
                                command1.Connection = cn;
                                command1.CommandText = "select * from pedido where fecha=? and cliente=?";
                                command1.Parameters.AddWithValue("fecha", fecha);
                                command1.Parameters.AddWithValue("cliente", nombre);
                                OleDbDataReader reader = command1.ExecuteReader();
                                reader.Read();
                                string result = reader.GetInt32(0).ToString();
                                return result;
                            }
                            

                        }
                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }
                    finally
                    {
                        cn.Close();
                    }

                    return "";
                }
            }
            catch (Exception ex)
            {
                return "false";
            }
            finally
            {
                cn.Close();
            }
        }
        public bool agregarplato(int id, int id_plato, int id_extra, int n)
        {
            OleDbConnection cn = new conexion().newcon();
            try
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = cn;
                    command.CommandText = "INSERT INTO detalle_plato (id_pedido, id_plato, id_extra, num) VALUES(?, ?, ?, ?)";
                    command.Parameters.AddWithValue("id_pedido", id);
                    command.Parameters.AddWithValue("id_plato", id_plato);
                    command.Parameters.AddWithValue("id_extra", id_extra);
                    command.Parameters.AddWithValue("num", n);

                    try
                    {
                        cn.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        if (recordsAffected > 0)
                        {
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                    finally
                    {
                        cn.Close();
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
