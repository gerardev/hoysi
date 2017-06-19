namespace delimerced.Platos
{
    partial class form_platos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_new = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Plato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(19, 65);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(161, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(19, 113);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(161, 20);
            this.txt_desc.TabIndex = 5;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(19, 164);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(161, 20);
            this.txt_price.TabIndex = 6;
            // 
            // txt_new
            // 
            this.txt_new.Location = new System.Drawing.Point(19, 200);
            this.txt_new.Name = "txt_new";
            this.txt_new.Size = new System.Drawing.Size(161, 23);
            this.txt_new.TabIndex = 7;
            this.txt_new.Text = "Agregar";
            this.txt_new.UseVisualStyleBackColor = true;
            this.txt_new.Click += new System.EventHandler(this.txt_new_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(211, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 119);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(211, 200);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(348, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // form_platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 244);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_new);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_platos";
            this.Text = "DELI MERCED";
            this.Load += new System.EventHandler(this.form_platos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button txt_new;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
    }
}