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
        
        OleDbCommandBuilder oledbCmdBuilder;
        DataSet ds = new DataSet();
        DataSet changes;


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
                filldata();
            }
            else
            {
                MessageBox.Show(rt, "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



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
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
        public void limpiar()
        {
            txt_name.Text = "";
            txt_desc.Text = "";
            txt_price.Text = "";
        }
        private void btn_update_Click(object sender, EventArgs e)
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
                MessageBox.Show("Cambios guardados exitosamente.","DELI MERCED", MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new Clases.conexion().newcon();
            string id_pl = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string sql = null;
            try
            {
                cn.Open();
                OleDbCommand cm = new OleDbCommand("delete from plato where id_plato=?");
                cm.Parameters.AddWithValue("id_plato", id_pl);
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                MessageBox.Show("Plato eliminado correctamente!", "DELI MERCED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "DELI MERCED");
            }
            finally
            {
                cn.Close();
            }


        }

        private void txt_clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
