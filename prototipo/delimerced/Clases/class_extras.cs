using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace delimerced.Clases
{
    class class_extras
    {
        public string agregar_extra(string name, string descr, string price)
        {
            try
            {
                OleDbConnection cn = new conexion().newcon();
                validaciones vali = new validaciones();
                if (vali.notempty(name) == true)
                {
                    if (vali.notempty(descr) == true)
                    {
                        if (vali.notempty(price) == true)
                        {
                            double precio = Convert.ToDouble(price);
                            using (OleDbCommand command = new OleDbCommand())
                            {
                                command.Connection = cn;
                                command.CommandText = "INSERT INTO extras (nombre, descripcion, precio) VALUES (@nombre, @descripcion, @precio)";

                                command.Parameters.AddWithValue("@nombre", name);
                                command.Parameters.AddWithValue("@descripcion", descr);
                                command.Parameters.AddWithValue("@precio", precio);

                                try
                                {
                                    cn.Open();
                                    int recordsAffected = command.ExecuteNonQuery();
                                    if (recordsAffected > 0)
                                    {
                                        return "true";
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
                                return "";
                            }
                        }
                        else
                        {
                            return "El campo Precio no puede estar vacío";
                        }
                    }
                    else
                    {
                        return "El campo Descripción no puede estar vacío";
                    }
                }
                else
                {
                    return "El campo Nombre no puede estar vacío";
                }
            }
            catch (Exception ex)
            {
                return "false";
            }
        }
    }
}
