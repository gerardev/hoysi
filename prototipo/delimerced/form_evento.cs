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
    public partial class form_evento : Form
    {
        string query = "SELECT * FROM evento";
        OleDbConnection cn = new Clases.conexion().newcon();

        OleDbCommandBuilder oledbCmdBuilder;
        DataSet ds = new DataSet();
        DataSet changes;


        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/hoysi/delimerced/delimerced/delimerced/bd/delimerced.mdb;Persist Security Info=True");
       
        public form_evento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnameE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpriceE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpriceE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsPunctuation(e.KeyChar))))
            {
                e.Handled = true;
                return;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eventoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.delimercedDataSet);

        }

        private void form_evento_Load(object sender, EventArgs e)
        {
            filldata();
        }

        private void btnsaveE_Click(object sender, EventArgs e) 
        {
            Clases.class_eventos eventos = new Clases.class_eventos();
            string add = eventos.agregar_evento(txtNameE.Text, dateE.Text, txtPriceE.Text, cbTypeE.Text, txtAddressE.Text);
            if (add == "true")
            {
                MessageBox.Show("Evento ingresado correctamente", "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameE.Text = "";
                dateE.Text = "";
                txtPriceE.Text = "";
                cbTypeE.Text = "";
                txtAddressE.Text = "";
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
                    eventoDataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnDeleteE_Click(object sender, EventArgs e)
        {
        }

        private void btnEditE_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, cn);
                OleDbCommandBuilder cmad = new OleDbCommandBuilder(adapter);
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
    }
}
