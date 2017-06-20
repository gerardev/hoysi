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
                filldata();
            }
            else
            {
                MessageBox.Show(add, "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void limpiar()
        {
            txtNameEx.Text = "";
            txtDescEx.Text = "";
            txtPriceEx.Text = "";
        }

        public void filldata()
        {

            OleDbDataAdapter adapter = new OleDbDataAdapter(query, cn);
            using (OleDbConnection cn = new Clases.conexion().newcon())
            {
                using (adapter)
                {
                    ds.Clear();
                    adapter.Fill(ds);
                    dataGridViewExtras.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnUpEx_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, cn);
                OleDbCommandBuilder cmad = new
                OleDbCommandBuilder(adapter);
                changes = ds.GetChanges();
                if (changes != null)
                {
                    adapter.Update(ds.Tables[0]);
                }
                ds.AcceptChanges();
                MessageBox.Show("Cambios guardados exitosamente", "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelEx_Click(object sender, EventArgs e)
        {
            int id_ex = Convert.ToInt16(dataGridViewExtras.CurrentRow.Cells[0].Value.ToString());
            Clases.class_extras extras = new Clases.class_extras();


            if (extras.borrar_extra(id_ex) == true)
            {
                MessageBox.Show("Extra eliminado correctamente!", "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filldata();
            }
            else
            {
                MessageBox.Show("Ocurrio un error. Intentelo de nuevo", "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
