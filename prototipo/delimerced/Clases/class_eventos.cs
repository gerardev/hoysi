using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace delimerced.Clases
{
    class class_eventos
    {
        public string agregar_evento(string name, string date, string price, string type, string direc)
        {
            try
            {
                OleDbConnection cn = new conexion().newcon();
                validaciones vali = new validaciones();
                

                if (vali.notempty(name) == true)
                {
                    if (vali.notempty(date) == true)
                    {
                        if (vali.notempty(price) == true)
                        {
                            if (vali.notempty(type) == true)
                            {
                                if (vali.notempty(direc) == true)
                                {
                                    DateTime fecha = Convert.ToDateTime(date);
                                    double precio = Convert.ToDouble(price);
                                    using (OleDbCommand command = new OleDbCommand())
                                    {
                                        command.Connection = cn;
                                        command.CommandText = "INSERT INTO evento (nombre, fecha, precio, tipo, direccion) VALUES (@nombre, @fecha, @precio, @tipo, @direccion)";

                                        command.Parameters.AddWithValue("@nombre", name);

                                        command.Parameters.AddWithValue("@fecha", fecha);

                                        command.Parameters.AddWithValue("@precio", precio);

                                        command.Parameters.AddWithValue("@tipo", type);

                                        command.Parameters.AddWithValue("@direccion", direc);

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
                                    return "El campo Dirección no puede estar vacio";
                                }
                            }
                            else
                            {
                                return "El campo Tipo no puede estar vacio";
                            }
                        }
                        else
                        {
                            return "El campo Precio no puede estar vacio";
                        }
                    }
                    else
                    {
                        return "El campo Fecha no puede estar vacío";
                    }
                }
                else
                {
                    return "El campo Nombre no puede estar vacío";
                }
            }
            catch (Exception ex)
            {
                return "false2";
            }
        }

        public bool borrar_evento(int id)
        {
            OleDbConnection cn = new conexion().newcon();
            try
            {
                cn.Open();
                OleDbCommand cm = new OleDbCommand("delete from evento where id_evento=?");
                cm.Parameters.AddWithValue("id_evento", id);
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                return true;
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
