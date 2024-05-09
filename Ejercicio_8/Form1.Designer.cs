namespace Ejercicio_8
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtNTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTablaMulti = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(158, 178);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(127, 36);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar Tabla";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtNTabla
            // 
            this.txtNTabla.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNTabla.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTabla.Location = new System.Drawing.Point(197, 146);
            this.txtNTabla.Name = "txtNTabla";
            this.txtNTabla.Size = new System.Drawing.Size(48, 26);
            this.txtNTabla.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el número de tabla que necesita";
            // 
            // txtTablaMulti
            // 
            this.txtTablaMulti.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtTablaMulti.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaMulti.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTablaMulti.Location = new System.Drawing.Point(149, 220);
            this.txtTablaMulti.Multiline = true;
            this.txtTablaMulti.Name = "txtTablaMulti";
            this.txtTablaMulti.Size = new System.Drawing.Size(145, 222);
            this.txtTablaMulti.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(300, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(423, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTablaMulti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNTabla);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form1";
            this.Text = "Tablas de Multiplicar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtNTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTablaMulti;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

