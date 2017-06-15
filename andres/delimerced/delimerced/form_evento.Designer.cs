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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnameE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateE = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpriceE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtaddressE = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnreportE = new System.Windows.Forms.Button();
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
            // txtnameE
            // 
            this.txtnameE.Location = new System.Drawing.Point(36, 39);
            this.txtnameE.Name = "txtnameE";
            this.txtnameE.Size = new System.Drawing.Size(271, 20);
            this.txtnameE.TabIndex = 1;
            this.txtnameE.TextChanged += new System.EventHandler(this.txtnameE_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // dateE
            // 
            this.dateE.Location = new System.Drawing.Point(379, 39);
            this.dateE.Name = "dateE";
            this.dateE.Size = new System.Drawing.Size(200, 20);
            this.dateE.TabIndex = 3;
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
            // txtpriceE
            // 
            this.txtpriceE.Location = new System.Drawing.Point(36, 111);
            this.txtpriceE.Name = "txtpriceE";
            this.txtpriceE.Size = new System.Drawing.Size(64, 20);
            this.txtpriceE.TabIndex = 5;
            this.txtpriceE.TextChanged += new System.EventHandler(this.txtpriceE_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo:";
            // 
            // cbtype
            // 
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Location = new System.Drawing.Point(129, 111);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(121, 21);
            this.cbtype.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección:";
            // 
            // txtaddressE
            // 
            this.txtaddressE.Location = new System.Drawing.Point(280, 111);
            this.txtaddressE.Name = "txtaddressE";
            this.txtaddressE.Size = new System.Drawing.Size(299, 20);
            this.txtaddressE.TabIndex = 9;
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
            this.btncancel.Location = new System.Drawing.Point(531, 272);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnreportE
            // 
            this.btnreportE.Location = new System.Drawing.Point(419, 272);
            this.btnreportE.Name = "btnreportE";
            this.btnreportE.Size = new System.Drawing.Size(90, 23);
            this.btnreportE.TabIndex = 12;
            this.btnreportE.Text = "Generar reporte";
            this.btnreportE.UseVisualStyleBackColor = true;
            // 
            // form_evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 307);
            this.Controls.Add(this.btnreportE);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtaddressE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpriceE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnameE);
            this.Controls.Add(this.label1);
            this.Name = "form_evento";
            this.Text = "Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnameE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpriceE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtaddressE;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnreportE;
    }
}