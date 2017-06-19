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
    public partial class form_evento : Form
    {
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
            // TODO: esta línea de código carga datos en la tabla 'delimercedDataSet.evento' Puede moverla o quitarla según sea necesario.
            this.eventoTableAdapter.Fill(this.delimercedDataSet.evento);

        }

        private void btnsaveE_Click(object sender, EventArgs e) 
        {
            decimal precio = Convert.ToDecimal(precioTextBox.Text);
            DateTime date = Convert.ToDateTime(fechaDateTimePicker.Text);
            //this.eventoTableAdapter.Insertar(nombreTextBox.Text, date, precio, cbtype.Text, direccionTextBox.Text);
            this.eventoTableAdapter.Fill(this.delimercedDataSet.evento);
        }

        private void btnDeleteE_Click(object sender, EventArgs e)
        {
        }

        private void btnEditE_Click(object sender, EventArgs e)
        {   
        }
    }
}
