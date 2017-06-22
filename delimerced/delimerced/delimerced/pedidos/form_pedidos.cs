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
    }
}
