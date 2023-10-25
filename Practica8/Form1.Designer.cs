namespace Practica8
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
            this.btncon = new System.Windows.Forms.Button();
            this.btndes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcon = new System.Windows.Forms.Label();
            this.lblmedtemp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncon
            // 
            this.btncon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncon.Location = new System.Drawing.Point(167, 337);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(120, 44);
            this.btncon.TabIndex = 0;
            this.btncon.Text = "Conectar";
            this.btncon.UseVisualStyleBackColor = true;
            this.btncon.Click += new System.EventHandler(this.btncon_Click);
            // 
            // btndes
            // 
            this.btndes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndes.Location = new System.Drawing.Point(504, 337);
            this.btndes.Name = "btndes";
            this.btndes.Size = new System.Drawing.Size(149, 44);
            this.btndes.TabIndex = 1;
            this.btndes.Text = "Desconectar";
            this.btndes.UseVisualStyleBackColor = true;
            this.btndes.Click += new System.EventHandler(this.btndes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Limite de temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatuta";
            // 
            // lblcon
            // 
            this.lblcon.AutoSize = true;
            this.lblcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcon.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblcon.Location = new System.Drawing.Point(167, 211);
            this.lblcon.Name = "lblcon";
            this.lblcon.Size = new System.Drawing.Size(178, 32);
            this.lblcon.TabIndex = 4;
            this.lblcon.Text = "Sin conexion";
            // 
            // lblmedtemp
            // 
            this.lblmedtemp.AutoSize = true;
            this.lblmedtemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedtemp.Location = new System.Drawing.Point(513, 176);
            this.lblmedtemp.Name = "lblmedtemp";
            this.lblmedtemp.Size = new System.Drawing.Size(152, 91);
            this.lblmedtemp.TabIndex = 5;
            this.lblmedtemp.Text = "0.0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practica8.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblmedtemp);
            this.Controls.Add(this.lblcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndes);
            this.Controls.Add(this.btncon);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncon;
        private System.Windows.Forms.Button btndes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcon;
        private System.Windows.Forms.Label lblmedtemp;
        private System.Windows.Forms.TextBox textBox1;
    }
}

