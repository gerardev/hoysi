using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delimerced2.Eventos
{
    public partial class eventos : Form
    {
        public eventos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtpriceE_TextChanged(object sender, EventArgs e)
        {
            if (char.IsDigit(e))
        }
    }
}
