namespace Ejercicio_5
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
            this.lblLap1 = new System.Windows.Forms.Label();
            this.lblLap2 = new System.Windows.Forms.Label();
            this.lblLap3 = new System.Windows.Forms.Label();
            this.txtLab1 = new System.Windows.Forms.TextBox();
            this.txtLab2 = new System.Windows.Forms.TextBox();
            this.txtLab3 = new System.Windows.Forms.TextBox();
            this.txtPar3 = new System.Windows.Forms.TextBox();
            this.txtPar2 = new System.Windows.Forms.TextBox();
            this.txtPar1 = new System.Windows.Forms.TextBox();
            this.lblPar3 = new System.Windows.Forms.Label();
            this.lblPar2 = new System.Windows.Forms.Label();
            this.lblPar1 = new System.Windows.Forms.Label();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.txtNotaFin = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLap1
            // 
            this.lblLap1.AutoSize = true;
            this.lblLap1.Location = new System.Drawing.Point(36, 208);
            this.lblLap1.Name = "lblLap1";
            this.lblLap1.Size = new System.Drawing.Size(69, 13);
            this.lblLap1.TabIndex = 0;
            this.lblLap1.Text = "Laboratorio 1";
            // 
            // lblLap2
            // 
            this.lblLap2.AutoSize = true;
            this.lblLap2.Location = new System.Drawing.Point(36, 237);
            this.lblLap2.Name = "lblLap2";
            this.lblLap2.Size = new System.Drawing.Size(69, 13);
            this.lblLap2.TabIndex = 1;
            this.lblLap2.Text = "Laboratorio 2";
            // 
            // lblLap3
            // 
            this.lblLap3.AutoSize = true;
            this.lblLap3.Location = new System.Drawing.Point(36, 270);
            this.lblLap3.Name = "lblLap3";
            this.lblLap3.Size = new System.Drawing.Size(69, 13);
            this.lblLap3.TabIndex = 2;
            this.lblLap3.Text = "Laboratorio 3";
            // 
            // txtLab1
            // 
            this.txtLab1.Location = new System.Drawing.Point(125, 206);
            this.txtLab1.Name = "txtLab1";
            this.txtLab1.Size = new System.Drawing.Size(35, 20);
            this.txtLab1.TabIndex = 3;
            // 
            // txtLab2
            // 
            this.txtLab2.Location = new System.Drawing.Point(125, 237);
            this.txtLab2.Name = "txtLab2";
            this.txtLab2.Size = new System.Drawing.Size(35, 20);
            this.txtLab2.TabIndex = 4;
            // 
            // txtLab3
            // 
            this.txtLab3.Location = new System.Drawing.Point(125, 270);
            this.txtLab3.Name = "txtLab3";
            this.txtLab3.Size = new System.Drawing.Size(35, 20);
            this.txtLab3.TabIndex = 5;
            // 
            // txtPar3
            // 
            this.txtPar3.Location = new System.Drawing.Point(312, 270);
            this.txtPar3.Name = "txtPar3";
            this.txtPar3.Size = new System.Drawing.Size(35, 20);
            this.txtPar3.TabIndex = 11;
            // 
            // txtPar2
            // 
            this.txtPar2.Location = new System.Drawing.Point(312, 237);
            this.txtPar2.Name = "txtPar2";
            this.txtPar2.Size = new System.Drawing.Size(35, 20);
            this.txtPar2.TabIndex = 10;
            // 
            // txtPar1
            // 
            this.txtPar1.Location = new System.Drawing.Point(312, 206);
            this.txtPar1.Name = "txtPar1";
            this.txtPar1.Size = new System.Drawing.Size(35, 20);
            this.txtPar1.TabIndex = 9;
            // 
            // lblPar3
            // 
            this.lblPar3.AutoSize = true;
            this.lblPar3.Location = new System.Drawing.Point(239, 270);
            this.lblPar3.Name = "lblPar3";
            this.lblPar3.Size = new System.Drawing.Size(48, 13);
            this.lblPar3.TabIndex = 8;
            this.lblPar3.Text = "Parcial 3";
            // 
            // lblPar2
            // 
            this.lblPar2.AutoSize = true;
            this.lblPar2.Location = new System.Drawing.Point(239, 237);
            this.lblPar2.Name = "lblPar2";
            this.lblPar2.Size = new System.Drawing.Size(48, 13);
            this.lblPar2.TabIndex = 7;
            this.lblPar2.Text = "Parcial 2";
            // 
            // lblPar1
            // 
            this.lblPar1.AutoSize = true;
            this.lblPar1.Location = new System.Drawing.Point(239, 208);
            this.lblPar1.Name = "lblPar1";
            this.lblPar1.Size = new System.Drawing.Size(48, 13);
            this.lblPar1.TabIndex = 6;
            this.lblPar1.Text = "Parcial 1";
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(103, 334);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(130, 32);
            this.btnPromedio.TabIndex = 12;
            this.btnPromedio.Text = "Calcular Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // txtNotaFin
            // 
            this.txtNotaFin.Location = new System.Drawing.Point(265, 340);
            this.txtNotaFin.Name = "txtNotaFin";
            this.txtNotaFin.Size = new System.Drawing.Size(100, 20);
            this.txtNotaFin.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(125, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Programación II";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Por favor ingrese notas obtenidas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(386, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNotaFin);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.txtPar3);
            this.Controls.Add(this.txtPar2);
            this.Controls.Add(this.txtPar1);
            this.Controls.Add(this.lblPar3);
            this.Controls.Add(this.lblPar2);
            this.Controls.Add(this.lblPar1);
            this.Controls.Add(this.txtLab3);
            this.Controls.Add(this.txtLab2);
            this.Controls.Add(this.txtLab1);
            this.Controls.Add(this.lblLap3);
            this.Controls.Add(this.lblLap2);
            this.Controls.Add(this.lblLap1);
            this.Name = "Form1";
            this.Text = "Promedio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLap1;
        private System.Windows.Forms.Label lblLap2;
        private System.Windows.Forms.Label lblLap3;
        private System.Windows.Forms.TextBox txtLab1;
        private System.Windows.Forms.TextBox txtLab2;
        private System.Windows.Forms.TextBox txtLab3;
        private System.Windows.Forms.TextBox txtPar3;
        private System.Windows.Forms.TextBox txtPar2;
        private System.Windows.Forms.TextBox txtPar1;
        private System.Windows.Forms.Label lblPar3;
        private System.Windows.Forms.Label lblPar2;
        private System.Windows.Forms.Label lblPar1;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.TextBox txtNotaFin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

