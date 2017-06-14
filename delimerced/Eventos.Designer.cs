namespace delimerced
{
    partial class Eventos
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
            this.lblEvento = new System.Windows.Forms.Label();
            this.txtnameE = new System.Windows.Forms.TextBox();
            this.lbldateE = new System.Windows.Forms.Label();
            this.dateE = new System.Windows.Forms.DateTimePicker();
            this.lblPrecioE = new System.Windows.Forms.Label();
            this.txtpriceE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnaddP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(25, 82);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(100, 13);
            this.lblEvento.TabIndex = 0;
            this.lblEvento.Text = "Nombre del evento:";
            this.lblEvento.Click += new System.EventHandler(this.lblEvento_Click);
            // 
            // txtnameE
            // 
            this.txtnameE.Location = new System.Drawing.Point(28, 98);
            this.txtnameE.Name = "txtnameE";
            this.txtnameE.Size = new System.Drawing.Size(283, 20);
            this.txtnameE.TabIndex = 1;
            // 
            // lbldateE
            // 
            this.lbldateE.AutoSize = true;
            this.lbldateE.Location = new System.Drawing.Point(336, 82);
            this.lbldateE.Name = "lbldateE";
            this.lbldateE.Size = new System.Drawing.Size(43, 13);
            this.lbldateE.TabIndex = 2;
            this.lbldateE.Text = "Fecha: ";
            // 
            // dateE
            // 
            this.dateE.Location = new System.Drawing.Point(339, 98);
            this.dateE.Name = "dateE";
            this.dateE.Size = new System.Drawing.Size(200, 20);
            this.dateE.TabIndex = 3;
            // 
            // lblPrecioE
            // 
            this.lblPrecioE.AutoSize = true;
            this.lblPrecioE.Location = new System.Drawing.Point(25, 121);
            this.lblPrecioE.Name = "lblPrecioE";
            this.lblPrecioE.Size = new System.Drawing.Size(55, 13);
            this.lblPrecioE.TabIndex = 4;
            this.lblPrecioE.Text = "Precio ($):";
            // 
            // txtpriceE
            // 
            this.txtpriceE.Location = new System.Drawing.Point(28, 137);
            this.txtpriceE.Name = "txtpriceE";
            this.txtpriceE.Size = new System.Drawing.Size(78, 20);
            this.txtpriceE.TabIndex = 5;
            this.txtpriceE.TextChanged += new System.EventHandler(this.txtpriceE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Servicio completo",
            "Solo comida"});
            this.comboBox1.Location = new System.Drawing.Point(129, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dirección:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(475, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(363, 338);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(93, 23);
            this.btn.TabIndex = 11;
            this.btn.Text = "Generar reporte";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnaddP
            // 
            this.btnaddP.Location = new System.Drawing.Point(28, 163);
            this.btnaddP.Name = "btnaddP";
            this.btnaddP.Size = new System.Drawing.Size(75, 23);
            this.btnaddP.TabIndex = 12;
            this.btnaddP.Text = "Agregar platos";
            this.btnaddP.UseVisualStyleBackColor = true;
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(562, 373);
            this.Controls.Add(this.btnaddP);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpriceE);
            this.Controls.Add(this.lblPrecioE);
            this.Controls.Add(this.dateE);
            this.Controls.Add(this.lbldateE);
            this.Controls.Add(this.txtnameE);
            this.Controls.Add(this.lblEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eventos";
            this.Text = "Eventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.TextBox txtnameE;
        private System.Windows.Forms.Label lbldateE;
        private System.Windows.Forms.DateTimePicker dateE;
        private System.Windows.Forms.Label lblPrecioE;
        private System.Windows.Forms.TextBox txtpriceE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnaddP;
    }
}