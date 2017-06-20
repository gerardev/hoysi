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
            this.btn_eventos = new System.Windows.Forms.Button();
            this.btn_pedidos = new System.Windows.Forms.Button();
            this.btn_platos = new System.Windows.Forms.Button();
            this.btnExtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_eventos
            // 
            this.btn_eventos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eventos.BackgroundImage")));
            this.btn_eventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eventos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eventos.Location = new System.Drawing.Point(12, 102);
            this.btn_eventos.Name = "btn_eventos";
            this.btn_eventos.Size = new System.Drawing.Size(125, 84);
            this.btn_eventos.TabIndex = 0;
            this.btn_eventos.UseVisualStyleBackColor = true;
            this.btn_eventos.Click += new System.EventHandler(this.button1_Click);
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
            // 
            // btn_platos
            // 
            this.btn_platos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_platos.BackgroundImage")));
            this.btn_platos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_platos.Location = new System.Drawing.Point(12, 192);
            this.btn_platos.Name = "btn_platos";
            this.btn_platos.Size = new System.Drawing.Size(125, 84);
            this.btn_platos.TabIndex = 2;
            this.btn_platos.UseVisualStyleBackColor = true;
            this.btn_platos.Click += new System.EventHandler(this.btn_platos_Click);
            // 
            // btnExtras
            // 
            this.btnExtras.Location = new System.Drawing.Point(143, 252);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(75, 23);
            this.btnExtras.TabIndex = 3;
            this.btnExtras.Text = "Extras";
            this.btnExtras.UseVisualStyleBackColor = true;
            this.btnExtras.Click += new System.EventHandler(this.btnExtras_Click);
            // 
            // form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 287);
            this.Controls.Add(this.btnExtras);
            this.Controls.Add(this.btn_platos);
            this.Controls.Add(this.btn_pedidos);
            this.Controls.Add(this.btn_eventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_inicio";
            this.Text = "DELI MERCED";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_eventos;
        private System.Windows.Forms.Button btn_pedidos;
        private System.Windows.Forms.Button btn_platos;
        private System.Windows.Forms.Button btnExtras;
    }
}