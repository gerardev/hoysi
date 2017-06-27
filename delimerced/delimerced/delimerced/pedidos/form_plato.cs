using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.OleDb;

namespace delimerced.pedidos
{
    public partial class form_plato : Form
    {
        public string Idpedido { get; set; }
        public form_plato()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void form_plato_Load(object sender, EventArgs e)
        {
            filldata();
            lbl_id.Text = Idpedido.ToString();
        }
        public void filldata()
        {
            cbplatos.DisplayMember = "text";
            cbplatos.ValueMember = "value";
            cbextras.DisplayMember = "text";
            cbextras.ValueMember = "value";
            OleDbConnection cn = new Clases.conexion().newcon();

            using (OleDbCommand command1 = new OleDbCommand())
            {
                cn.Open();
                command1.Connection = cn;
                command1.CommandText = "select Id_plato, nombre, precio from plato";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    string id_plato = reader.GetInt32(0).ToString(); 
                    string nombre = reader.GetString(1).ToString();
                    string precio = reader.GetDouble(2).ToString();
                    string info = "(" + precio + "$)" + nombre;
                    cbplatos.Items.Add(new { text = info, value = id_plato });
                }
            }
            using (OleDbCommand command1 = new OleDbCommand())
            {
                command1.Connection = cn;
                command1.CommandText = "select Id_extra, nombre, precio from extras";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    string id_plato = reader.GetInt32(0).ToString();
                    string nombre = reader.GetString(1).ToString();
                    string precio = reader.GetDouble(2).ToString();
                    string info = "(" + precio + "$)" + nombre;
                    cbextras.Items.Add(new { text = info, value = id_plato });
                }
            }
        }

        private void cbplatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text = ""; 
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string value = cbplatos.Text;
            if (idplato(value) > 0)
            {
                int id = Convert.ToInt32(Idpedido.ToString());
                int idp = idplato(value);
                string extrav = cbextras.Text;
                if (idextra(extrav) > 0)
                {
                    int idex = idextra(extrav);
                    Clases.validaciones val = new Clases.validaciones();
                    if (val.notempty(txt_cantidad.Text) == true)
                    {
                        int num = Convert.ToInt16(txt_cantidad.Text);
                        Clases.class_pedidos ped = new Clases.class_pedidos();
                        if (ped.agregarplato(Convert.ToInt32(Idpedido.ToString()), idp, idex, num) == true)
                        {
                            MessageBox.Show("Platos ingresados correctamente");
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show(":(");
                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }



        }
        static int idplato(string value)
        {
            
            string[] datos = value.Split(')');
            using (OleDbConnection cn = new Clases.conexion().newcon())
            {
                try
                {
                    cn.Open();
                    using (OleDbCommand command = new OleDbCommand())
                    {
                        command.CommandText = "select Id_plato from plato where nombre=?";
                        command.Parameters.AddWithValue("nombre", datos[1]);
                        command.Connection = cn;
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }


                    }

                }
                catch(Exception ex)
                {
                    return 0;
                }
                finally
                {
                    cn.Close();
                }
            }
            return 0;
        }
        static int idextra(string value)
        {

            string[] datos = value.Split(')');
            using (OleDbConnection cn = new Clases.conexion().newcon())
            {
                try
                {
                    cn.Open();
                    using (OleDbCommand command = new OleDbCommand())
                    {
                        command.CommandText = "select Id_extra from extras where nombre=?";
                        command.Parameters.AddWithValue("nombre", datos[1]);
                        command.Connection = cn;
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }


                    }

                }
                catch (Exception ex)
                {
                    return 0;
                }
                finally
                {
                    cn.Close();
                }
            }
            return 0;
        }
    }
}
