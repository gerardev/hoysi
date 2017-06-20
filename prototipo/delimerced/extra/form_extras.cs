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
    public partial class form_extras : Form
    {
        string query = "SELECT * FROM extras";
        OleDbConnection cn = new Clases.conexion().newcon();

        OleDbCommandBuilder oledbCmBuilder;
        DataSet ds = new DataSet();
        DataSet changes;

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/hoysi/delimerced/delimerced/delimerced/bd/delimerced.mdb;Persist Security Info=True");

        public form_extras()
        {
            InitializeComponent();
        }

        private void form_extras_Load(object sender, EventArgs e)
        {
            filldata();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEx_Click(object sender, EventArgs e)
        {
            Clases.class_extras extras = new Clases.class_extras();
            string add = extras.agregar_extra(txtNameEx.Text, txtDescEx.Text, txtPriceEx.Text);
            if (add == "true")
            {
                MessageBox.Show("Extra ingresado correctamente", "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameEx.Text = "";
                txtDescEx.Text = "";
                txtPriceEx.Text = "";
            }
            else
            {
                MessageBox.Show(add, "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void filldata()
        {

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, cn);
            using (OleDbConnection cn = new Clases.conexion().newcon())
            {
                using (adapter)
                {
                    adapter.Fill(ds);
                    dataGridViewExtras.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
