namespace guia2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnlistar = new System.Windows.Forms.Button();
            this.bttnagregar = new System.Windows.Forms.Button();
            this.bttnver = new System.Windows.Forms.Button();
            this.bttnmodificar = new System.Windows.Forms.Button();
            this.bttneliminar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bttnlistar
            // 
            this.bttnlistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnlistar.Location = new System.Drawing.Point(505, 46);
            this.bttnlistar.Name = "bttnlistar";
            this.bttnlistar.Size = new System.Drawing.Size(171, 70);
            this.bttnlistar.TabIndex = 0;
            this.bttnlistar.Text = "Listar";
            this.bttnlistar.UseVisualStyleBackColor = true;
            this.bttnlistar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnagregar
            // 
            this.bttnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnagregar.Location = new System.Drawing.Point(505, 122);
            this.bttnagregar.Name = "bttnagregar";
            this.bttnagregar.Size = new System.Drawing.Size(171, 70);
            this.bttnagregar.TabIndex = 1;
            this.bttnagregar.Text = "Agregar";
            this.bttnagregar.UseVisualStyleBackColor = true;
            this.bttnagregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnver
            // 
            this.bttnver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnver.Location = new System.Drawing.Point(505, 198);
            this.bttnver.Name = "bttnver";
            this.bttnver.Size = new System.Drawing.Size(171, 70);
            this.bttnver.TabIndex = 2;
            this.bttnver.Text = "Ver";
            this.bttnver.UseVisualStyleBackColor = true;
            this.bttnver.Click += new System.EventHandler(this.bttnver_Click);
            // 
            // bttnmodificar
            // 
            this.bttnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnmodificar.Location = new System.Drawing.Point(505, 274);
            this.bttnmodificar.Name = "bttnmodificar";
            this.bttnmodificar.Size = new System.Drawing.Size(171, 70);
            this.bttnmodificar.TabIndex = 3;
            this.bttnmodificar.Text = "Modificar";
            this.bttnmodificar.UseVisualStyleBackColor = true;
            this.bttnmodificar.Click += new System.EventHandler(this.bttnmodificar_Click);
            // 
            // bttneliminar
            // 
            this.bttneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttneliminar.Location = new System.Drawing.Point(505, 350);
            this.bttneliminar.Name = "bttneliminar";
            this.bttneliminar.Size = new System.Drawing.Size(171, 70);
            this.bttneliminar.TabIndex = 4;
            this.bttneliminar.Text = "Eliminar";
            this.bttneliminar.UseVisualStyleBackColor = true;
            this.bttneliminar.Click += new System.EventHandler(this.bttneliminar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(465, 404);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 457);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bttneliminar);
            this.Controls.Add(this.bttnmodificar);
            this.Controls.Add(this.bttnver);
            this.Controls.Add(this.bttnagregar);
            this.Controls.Add(this.bttnlistar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnlistar;
        private System.Windows.Forms.Button bttnagregar;
        private System.Windows.Forms.Button bttnver;
        private System.Windows.Forms.Button bttnmodificar;
        private System.Windows.Forms.Button bttneliminar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

