namespace Ejercicio_6
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblviñeta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResltado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(34, 318);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click_1);
            // 
            // txtnumero
            // 
            this.txtnumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumero.Location = new System.Drawing.Point(276, 226);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(53, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // lblviñeta
            // 
            this.lblviñeta.AutoSize = true;
            this.lblviñeta.BackColor = System.Drawing.Color.Transparent;
            this.lblviñeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblviñeta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviñeta.ForeColor = System.Drawing.Color.Black;
            this.lblviñeta.Location = new System.Drawing.Point(34, 225);
            this.lblviñeta.Name = "lblviñeta";
            this.lblviñeta.Size = new System.Drawing.Size(199, 21);
            this.lblviñeta.TabIndex = 2;
            this.lblviñeta.Text = "Ingrese Números del 1 al 20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Conversor a Romanos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResltado
            // 
            this.lblResltado.AutoSize = true;
            this.lblResltado.BackColor = System.Drawing.Color.Transparent;
            this.lblResltado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResltado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResltado.Location = new System.Drawing.Point(131, 322);
            this.lblResltado.Name = "lblResltado";
            this.lblResltado.Size = new System.Drawing.Size(2, 17);
            this.lblResltado.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResltado);
            this.Controls.Add(this.lblviñeta);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.btnConvertir);
            this.Name = "Form1";
            this.Text = "Romanos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblviñeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResltado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

