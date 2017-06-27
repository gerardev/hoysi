using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace delimerced.pedidos
{
    public partial class form_pedidos : Form
    {
        DataSet ds = new DataSet();
        public form_pedidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form_pedidos_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_plato plato = new form_plato();
            plato.Idpedido = lblid.Text;
            plato.Show();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.validaciones val = new Clases.validaciones();
            string cliente = txt_nombre.Text;
            string direccion = txtdir.Text;
            string tipo = cbtipo.Text;

            if (val.notempty(cliente) == true)
            {
                if (val.notempty(direccion) == true)
                {
                    if (val.notempty(direccion) == true)
                    {
                        Clases.class_pedidos pedidos = new Clases.class_pedidos();
                        lblid.Text = pedidos.crearpedido(cliente, direccion, tipo);

                        if (lblid.Text != "")
                        {
                            txt_nombre.Enabled = false;
                            txtdir.Enabled = false;
                            cbtipo.Enabled = false;
                            datapedidos.Enabled = true;
                            btn_guardar1.Enabled = false;

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("El campo Dirección no puede quedar vacio", "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El campo Tipo no puede quedar vacio", "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El campo Nombre no puede quedar vacio", "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void datapedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdir_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
        public void filldata()
        {
            using (OleDbConnection cn = new Clases.conexion().newcon())
            {
                try
                {
                    datapedidos.ColumnCount = 4;
                    datapedidos.Columns[0].Name = "Nombre del plato";
                    datapedidos.Columns[1].Name = "Nombre del extra";
                    datapedidos.Columns[2].Name = "Cantidad de platos";
                    datapedidos.Columns[3].Name = "Precio";
                    cn.Open();
                    string query1 = "SELECT id_plato, id_extra, num FROM detalle_plato WHERE id_pedido =" + lblid.Text;

                    try
                    {
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = cn;
                        command.CommandText = query1;
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int id_plato = reader.GetInt32(0);
                            int id_extra = reader.GetInt32(1);
                            int cant = reader.GetInt32(2);



                            OleDbCommand cm2 = new OleDbCommand();
                            cm2.Connection = cn;
                            string query2 = "SELECT nombre, precio FROM plato WHERE Id_plato=" + id_plato;
                            cm2.CommandText = query2;
                            OleDbDataReader r2 = cm2.ExecuteReader();
                            r2.Read();
                            string nombre_plato = r2.GetString(0);
                            double precio_plato = r2.GetDouble(1);


                            OleDbCommand cm3 = new OleDbCommand();
                            cm3.Connection = cn;
                            string query3 = "SELECT nombre, precio FROM extras WHERE Id_extra=" + id_extra;
                            cm3.CommandText = query3;
                            OleDbDataReader r3 = cm3.ExecuteReader();
                            r3.Read();
                            string nombre_extra = r3.GetString(0);
                            double precio_extra = r3.GetDouble(1);


                            double precio = cant * (precio_extra + precio_plato);


                            string[] row = new string[] { nombre_plato, nombre_extra, cant.ToString(), precio.ToString() };
                            datapedidos.Rows.Add(row);
                        }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    cn.Close();

                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            filldata();
        }
    }
}
