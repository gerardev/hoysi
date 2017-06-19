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
    public partial class form_carga : Form
    {
        public form_carga()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            form_login login = new form_login();
            login.Show();
            timer.Enabled = false;
        }
    }
}
