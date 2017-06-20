namespace delimerced
{
    partial class form_extras
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
            this.txtNameEx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescEx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPriceEx = new System.Windows.Forms.TextBox();
            this.dataGridViewExtras = new System.Windows.Forms.DataGridView();
            this.btnAddEx = new System.Windows.Forms.Button();
            this.btnUpEx = new System.Windows.Forms.Button();
            this.btnDelEx = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNameEx
            // 
            this.txtNameEx.Location = new System.Drawing.Point(15, 47);
            this.txtNameEx.Name = "txtNameEx";
            this.txtNameEx.Size = new System.Drawing.Size(127, 20);
            this.txtNameEx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDescEx
            // 
            this.txtDescEx.Location = new System.Drawing.Point(15, 106);
            this.txtDescEx.Name = "txtDescEx";
            this.txtDescEx.Size = new System.Drawing.Size(127, 20);
            this.txtDescEx.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio:";
            // 
            // txtPriceEx
            // 
            this.txtPriceEx.Location = new System.Drawing.Point(15, 161);
            this.txtPriceEx.Name = "txtPriceEx";
            this.txtPriceEx.Size = new System.Drawing.Size(127, 20);
            this.txtPriceEx.TabIndex = 6;
            // 
            // dataGridViewExtras
            // 
            this.dataGridViewExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExtras.Location = new System.Drawing.Point(164, 47);
            this.dataGridViewExtras.Name = "dataGridViewExtras";
            this.dataGridViewExtras.Size = new System.Drawing.Size(408, 134);
            this.dataGridViewExtras.TabIndex = 7;
            // 
            // btnAddEx
            // 
            this.btnAddEx.Location = new System.Drawing.Point(15, 205);
            this.btnAddEx.Name = "btnAddEx";
            this.btnAddEx.Size = new System.Drawing.Size(127, 23);
            this.btnAddEx.TabIndex = 8;
            this.btnAddEx.Text = "Agregar";
            this.btnAddEx.UseVisualStyleBackColor = true;
            this.btnAddEx.Click += new System.EventHandler(this.btnAddEx_Click);
            // 
            // btnUpEx
            // 
            this.btnUpEx.Location = new System.Drawing.Point(164, 205);
            this.btnUpEx.Name = "btnUpEx";
            this.btnUpEx.Size = new System.Drawing.Size(153, 23);
            this.btnUpEx.TabIndex = 9;
            this.btnUpEx.Text = "Actualizar";
            this.btnUpEx.UseVisualStyleBackColor = true;
            this.btnUpEx.Click += new System.EventHandler(this.btnUpEx_Click);
            // 
            // btnDelEx
            // 
            this.btnDelEx.Location = new System.Drawing.Point(342, 205);
            this.btnDelEx.Name = "btnDelEx";
            this.btnDelEx.Size = new System.Drawing.Size(153, 23);
            this.btnDelEx.TabIndex = 10;
            this.btnDelEx.Text = "Eliminar";
            this.btnDelEx.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(507, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // form_extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 267);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelEx);
            this.Controls.Add(this.btnUpEx);
            this.Controls.Add(this.btnAddEx);
            this.Controls.Add(this.dataGridViewExtras);
            this.Controls.Add(this.txtPriceEx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameEx);
            this.Controls.Add(this.label1);
            this.Name = "form_extras";
            this.Text = "DELI MERCED";
            this.Load += new System.EventHandler(this.form_extras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescEx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPriceEx;
        private System.Windows.Forms.DataGridView dataGridViewExtras;
        private System.Windows.Forms.Button btnAddEx;
        private System.Windows.Forms.Button btnUpEx;
        private System.Windows.Forms.Button btnDelEx;
        private System.Windows.Forms.Button btnCancel;
    }
}