namespace delimerced.pedidos
{
    partial class form_pedidos
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.datapedidos = new System.Windows.Forms.DataGridView();
            this.btn_guardar1 = new System.Windows.Forms.Button();
            this.btn_addplato = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datapedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(16, 28);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(233, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(16, 74);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(483, 20);
            this.txtdir.TabIndex = 1;
            this.txtdir.TextChanged += new System.EventHandler(this.txtdir_TextChanged);
            // 
            // datapedidos
            // 
            this.datapedidos.BackgroundColor = System.Drawing.Color.White;
            this.datapedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datapedidos.Enabled = false;
            this.datapedidos.Location = new System.Drawing.Point(16, 116);
            this.datapedidos.Name = "datapedidos";
            this.datapedidos.Size = new System.Drawing.Size(483, 334);
            this.datapedidos.TabIndex = 3;
            this.datapedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datapedidos_CellContentClick);
            // 
            // btn_guardar1
            // 
            this.btn_guardar1.BackColor = System.Drawing.Color.Black;
            this.btn_guardar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar1.ForeColor = System.Drawing.Color.White;
            this.btn_guardar1.Location = new System.Drawing.Point(514, 28);
            this.btn_guardar1.Name = "btn_guardar1";
            this.btn_guardar1.Size = new System.Drawing.Size(159, 23);
            this.btn_guardar1.TabIndex = 4;
            this.btn_guardar1.Text = "Crear pedido";
            this.btn_guardar1.UseVisualStyleBackColor = false;
            this.btn_guardar1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addplato
            // 
            this.btn_addplato.BackColor = System.Drawing.Color.Black;
            this.btn_addplato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addplato.ForeColor = System.Drawing.Color.White;
            this.btn_addplato.Location = new System.Drawing.Point(514, 57);
            this.btn_addplato.Name = "btn_addplato";
            this.btn_addplato.Size = new System.Drawing.Size(159, 23);
            this.btn_addplato.TabIndex = 5;
            this.btn_addplato.Text = "Agregar Plato";
            this.btn_addplato.UseVisualStyleBackColor = false;
            this.btn_addplato.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Black;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(514, 86);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(159, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(13, 12);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 7;
            this.Nombre.Text = "Nombre";
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Location = new System.Drawing.Point(266, 28);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(233, 21);
            this.cbtipo.TabIndex = 8;
            this.cbtipo.SelectedIndexChanged += new System.EventHandler(this.cbtipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dirección";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(514, 116);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(514, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Actualizar vista";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // form_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(687, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_addplato);
            this.Controls.Add(this.btn_guardar1);
            this.Controls.Add(this.datapedidos);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.txt_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_pedidos";
            this.Text = "DELI MERCED";
            this.Load += new System.EventHandler(this.form_pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datapedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.DataGridView datapedidos;
        private System.Windows.Forms.Button btn_guardar1;
        private System.Windows.Forms.Button btn_addplato;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button button1;
    }
}