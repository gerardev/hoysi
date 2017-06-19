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

namespace delimerced
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Clases.class_login log = new Clases.class_login();
            if (log.log(txt_user.Text, txt_password.Text) == true)
            {
                this.Close();
                form_inicio inicio = new form_inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta",
                            "DELI MERCED",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                    );
            }
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
