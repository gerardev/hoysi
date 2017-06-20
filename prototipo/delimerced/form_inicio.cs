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
            form_evento evento = new form_evento();
            evento.Show();
        }

        private void btn_platos_Click(object sender, EventArgs e)
        {
            Platos.form_platos platos = new Platos.form_platos();
            platos.Show();
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            form_extras extras = new form_extras();
            extras.Show();
        }
    }
}
