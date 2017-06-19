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

namespace delimerced.Platos
{
    
    public partial class form_platos : Form
    {
        string query = "SELECT * FROM plato";
        OleDbConnection cn = new Clases.conexion().newcon();
        //OleDbDataAdapter adapter = new OleDbDataAdapter(query, cn);
        //OleDbCommandBuilder oledbCmdBuilder =;
        DataSet ds = new DataSet();
        DataSet changes;
        int i;
        string Sql;


        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/hoysi/delimerced/delimerced/delimerced/bd/delimerced.mdb;Persist Security Info=True");
        public form_platos()
        {
            InitializeComponent();
        }

        private void form_platos_Load(object sender, EventArgs e)
        {
            filldata();

        }

        private void txt_new_Click(object sender, EventArgs e)
        {
            Clases.class_platos platos = new Clases.class_platos();
            string rt = platos.agregar_plato(txt_name.Text, txt_desc.Text, txt_price.Text);
            if (rt == "true")
            {
                MessageBox.Show("Plato Ingresado Correctamente", "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_name.Text = "";
                txt_desc.Text = "";
                txt_price.Text = "";
            }
            else
            {
                MessageBox.Show(rt, "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }
        public void filldata()
        {
            

            using (OleDbConnection cn = new Clases.conexion().newcon())
            {
                using (adapter)
                {
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommandBuilder cmad = new OleDbCommandBuilder(adapter);
                changes = ds.GetChanges();
                if (changes != null)
                {
                   // oledbAdapter.Update(ds.Tables[0]);
                }
                ds.AcceptChanges();
                MessageBox.Show("Save changes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
