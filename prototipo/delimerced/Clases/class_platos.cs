using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace delimerced.Clases
{
    class class_platos
    {

        public string agregar_plato(string nombre, string descr, string price)
        {
            try
            {
                OleDbConnection cn = new conexion().newcon();
                validaciones vali = new validaciones();


                if (vali.notempty(nombre) == true)
                {
                    if (vali.notempty(descr) == true)
                    {
                        if ((vali.notempty(price) == true) && (vali.onlynumbers(price) == true))
                        {   
                            double precio = Convert.ToDouble(price);
                            using (OleDbCommand command = new OleDbCommand())
                            {
                                command.Connection = cn;
                                command.CommandText = "INSERT INTO plato (nombre, descripcion, precio) VALUES(@nombre,@descripcion,@precio)";
                                command.Parameters.AddWithValue("@nombre", nombre);
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
                            return "El campo Precio no puede estar vacio";
                        }
                    }
                    else
                    {
                        return "El campo Descripción no puede estar vacio";
                    }
                }
                else
                {
                    return "El campo Nombre no puede estar vacio";
                }
            }
            catch (Exception ex)
            {
                return "false";
            }
        }
    }
}
