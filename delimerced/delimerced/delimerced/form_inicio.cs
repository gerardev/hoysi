using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delimerced
{
    public partial class form_inicio : Form
    {
        public form_inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_platos_Click(object sender, EventArgs e)
        {
            Platos.form_platos platos = new Platos.form_platos();
            platos.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Extras.form_extras extras = new Extras.form_extras();
            extras.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_acerca acerca = new form_acerca();
            acerca.Show();
        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            pedidos.form_pedidos ped = new pedidos.form_pedidos();
            ped.Show();
        }
    }
}
