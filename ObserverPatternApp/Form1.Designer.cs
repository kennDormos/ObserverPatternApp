namespace ObserverPatternApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxTemperatura = new System.Windows.Forms.TextBox();
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.buttonCambiarTemperatura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTemperatura
            // 
            this.textBoxTemperatura.BackColor = System.Drawing.Color.White;
            this.textBoxTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTemperatura.Font = new System.Drawing.Font("Satoshi Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTemperatura.Location = new System.Drawing.Point(138, 12);
            this.textBoxTemperatura.Multiline = true;
            this.textBoxTemperatura.Name = "textBoxTemperatura";
            this.textBoxTemperatura.Size = new System.Drawing.Size(282, 54);
            this.textBoxTemperatura.TabIndex = 0;
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Font = new System.Drawing.Font("Satoshi Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatura.Location = new System.Drawing.Point(141, 78);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(61, 24);
            this.labelTemperatura.TabIndex = 1;
            this.labelTemperatura.Text = "label1";
            // 
            // buttonCambiarTemperatura
            // 
            this.buttonCambiarTemperatura.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarTemperatura.Location = new System.Drawing.Point(153, 191);
            this.buttonCambiarTemperatura.Name = "buttonCambiarTemperatura";
            this.buttonCambiarTemperatura.Size = new System.Drawing.Size(267, 23);
            this.buttonCambiarTemperatura.TabIndex = 2;
            this.buttonCambiarTemperatura.Text = "Cambiar Temperatura";
            this.buttonCambiarTemperatura.UseVisualStyleBackColor = true;
            this.buttonCambiarTemperatura.Click += new System.EventHandler(this.buttonCambiarTemperatura_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 226);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCambiarTemperatura);
            this.Controls.Add(this.labelTemperatura);
            this.Controls.Add(this.textBoxTemperatura);
            this.Name = "Form1";
            this.Text = "Temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTemperatura;
        private System.Windows.Forms.Label labelTemperatura;
        private System.Windows.Forms.Button buttonCambiarTemperatura;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

