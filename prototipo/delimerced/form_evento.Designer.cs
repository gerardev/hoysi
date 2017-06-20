namespace delimerced
{
    partial class form_evento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnreportE = new System.Windows.Forms.Button();
            this.eventoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delimercedDataSet = new delimerced.delimercedDataSet();
            this.btnsaveE = new System.Windows.Forms.Button();
            this.cbTypeE = new System.Windows.Forms.ComboBox();
            this.eventoTableAdapter = new delimerced.delimercedDataSetTableAdapters.eventoTableAdapter();
            this.tableAdapterManager = new delimerced.delimercedDataSetTableAdapters.TableAdapterManager();
            this.btnDeleteE = new System.Windows.Forms.Button();
            this.btnEditE = new System.Windows.Forms.Button();
            this.txtNameE = new System.Windows.Forms.TextBox();
            this.dateE = new System.Windows.Forms.DateTimePicker();
            this.txtPriceE = new System.Windows.Forms.TextBox();
            this.txtAddressE = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimercedDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del evento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio ($):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección:";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(36, 152);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(88, 23);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Agregar platos";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(597, 362);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnreportE
            // 
            this.btnreportE.Location = new System.Drawing.Point(488, 362);
            this.btnreportE.Name = "btnreportE";
            this.btnreportE.Size = new System.Drawing.Size(90, 23);
            this.btnreportE.TabIndex = 12;
            this.btnreportE.Text = "Generar reporte";
            this.btnreportE.UseVisualStyleBackColor = true;
            // 
            // eventoDataGridView
            // 
            this.eventoDataGridView.AutoGenerateColumns = false;
            this.eventoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.eventoDataGridView.DataSource = this.eventoBindingSource;
            this.eventoDataGridView.Location = new System.Drawing.Point(36, 181);
            this.eventoDataGridView.Name = "eventoDataGridView";
            this.eventoDataGridView.Size = new System.Drawing.Size(636, 155);
            this.eventoDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_evento";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_evento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn5.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn6.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataMember = "evento";
            this.eventoBindingSource.DataSource = this.delimercedDataSet;
            // 
            // delimercedDataSet
            // 
            this.delimercedDataSet.DataSetName = "delimercedDataSet";
            this.delimercedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnsaveE
            // 
            this.btnsaveE.Location = new System.Drawing.Point(36, 362);
            this.btnsaveE.Name = "btnsaveE";
            this.btnsaveE.Size = new System.Drawing.Size(92, 23);
            this.btnsaveE.TabIndex = 15;
            this.btnsaveE.Text = "Guardar";
            this.btnsaveE.UseVisualStyleBackColor = true;
            this.btnsaveE.Click += new System.EventHandler(this.btnsaveE_Click);
            // 
            // cbTypeE
            // 
            this.cbTypeE.FormattingEnabled = true;
            this.cbTypeE.Items.AddRange(new object[] {
            "Servicio completo",
            "Solo comida"});
            this.cbTypeE.Location = new System.Drawing.Point(163, 110);
            this.cbTypeE.Name = "cbTypeE";
            this.cbTypeE.Size = new System.Drawing.Size(121, 21);
            this.cbTypeE.TabIndex = 21;
            // 
            // eventoTableAdapter
            // 
            this.eventoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.comprasTableAdapter = null;
            this.tableAdapterManager.detalle_eventoTableAdapter = null;
            this.tableAdapterManager.detalle_pedidoTableAdapter = null;
            this.tableAdapterManager.detalle_platoTableAdapter = null;
            this.tableAdapterManager.detalle_platTableAdapter = null;
            this.tableAdapterManager.eventoTableAdapter = this.eventoTableAdapter;
            this.tableAdapterManager.extrasTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.platoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = delimerced.delimercedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // btnDeleteE
            // 
            this.btnDeleteE.Location = new System.Drawing.Point(370, 362);
            this.btnDeleteE.Name = "btnDeleteE";
            this.btnDeleteE.Size = new System.Drawing.Size(92, 23);
            this.btnDeleteE.TabIndex = 22;
            this.btnDeleteE.Text = "Borrar ";
            this.btnDeleteE.UseVisualStyleBackColor = true;
            this.btnDeleteE.Click += new System.EventHandler(this.btnDeleteE_Click);
            // 
            // btnEditE
            // 
            this.btnEditE.Location = new System.Drawing.Point(255, 362);
            this.btnEditE.Name = "btnEditE";
            this.btnEditE.Size = new System.Drawing.Size(98, 23);
            this.btnEditE.TabIndex = 24;
            this.btnEditE.Text = "Actualizar ";
            this.btnEditE.UseVisualStyleBackColor = true;
            this.btnEditE.Click += new System.EventHandler(this.btnEditE_Click);
            // 
            // txtNameE
            // 
            this.txtNameE.Location = new System.Drawing.Point(36, 40);
            this.txtNameE.Name = "txtNameE";
            this.txtNameE.Size = new System.Drawing.Size(344, 20);
            this.txtNameE.TabIndex = 25;
            // 
            // dateE
            // 
            this.dateE.Location = new System.Drawing.Point(438, 39);
            this.dateE.Name = "dateE";
            this.dateE.Size = new System.Drawing.Size(218, 20);
            this.dateE.TabIndex = 26;
            // 
            // txtPriceE
            // 
            this.txtPriceE.Location = new System.Drawing.Point(36, 110);
            this.txtPriceE.Name = "txtPriceE";
            this.txtPriceE.Size = new System.Drawing.Size(100, 20);
            this.txtPriceE.TabIndex = 27;
            this.txtPriceE.TextChanged += new System.EventHandler(this.txtPriceE_TextChanged_1);
            // 
            // txtAddressE
            // 
            this.txtAddressE.Location = new System.Drawing.Point(328, 110);
            this.txtAddressE.Name = "txtAddressE";
            this.txtAddressE.Size = new System.Drawing.Size(328, 20);
            this.txtAddressE.TabIndex = 28;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(134, 362);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(98, 23);
            this.btnClean.TabIndex = 29;
            this.btnClean.Text = "Limpiar formulario";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // form_evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 469);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtAddressE);
            this.Controls.Add(this.txtPriceE);
            this.Controls.Add(this.dateE);
            this.Controls.Add(this.txtNameE);
            this.Controls.Add(this.btnEditE);
            this.Controls.Add(this.btnDeleteE);
            this.Controls.Add(this.cbTypeE);
            this.Controls.Add(this.btnsaveE);
            this.Controls.Add(this.eventoDataGridView);
            this.Controls.Add(this.btnreportE);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_evento";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.form_evento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimercedDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnreportE;
        private delimercedDataSet delimercedDataSet;
        private System.Windows.Forms.BindingSource eventoBindingSource;
        private delimercedDataSetTableAdapters.eventoTableAdapter eventoTableAdapter;
        private delimercedDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView eventoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnsaveE;
        private System.Windows.Forms.ComboBox cbTypeE;
        private System.Windows.Forms.Button btnDeleteE;
        private System.Windows.Forms.Button btnEditE;
        private System.Windows.Forms.TextBox txtNameE;
        private System.Windows.Forms.DateTimePicker dateE;
        private System.Windows.Forms.TextBox txtPriceE;
        private System.Windows.Forms.TextBox txtAddressE;
        private System.Windows.Forms.Button btnClean;
    }
}