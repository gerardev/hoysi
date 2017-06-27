namespace delimerced
{
    partial class form_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_inicio));
            this.btn_pedidos = new System.Windows.Forms.Button();
            this.btn_platos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pedidos
            // 
            this.btn_pedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pedidos.BackgroundImage")));
            this.btn_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pedidos.Location = new System.Drawing.Point(12, 12);
            this.btn_pedidos.Name = "btn_pedidos";
            this.btn_pedidos.Size = new System.Drawing.Size(125, 84);
            this.btn_pedidos.TabIndex = 1;
            this.btn_pedidos.UseVisualStyleBackColor = true;
            this.btn_pedidos.Click += new System.EventHandler(this.btn_pedidos_Click);
            // 
            // btn_platos
            // 
            this.btn_platos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_platos.BackgroundImage")));
            this.btn_platos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_platos.Location = new System.Drawing.Point(143, 12);
            this.btn_platos.Name = "btn_platos";
            this.btn_platos.Size = new System.Drawing.Size(125, 84);
            this.btn_platos.TabIndex = 2;
            this.btn_platos.UseVisualStyleBackColor = true;
            this.btn_platos.Click += new System.EventHandler(this.btn_platos_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 84);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Acerca de...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(281, 200);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_platos);
            this.Controls.Add(this.btn_pedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_inicio";
            this.Text = "DELI MERCED";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_pedidos;
        private System.Windows.Forms.Button btn_platos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}