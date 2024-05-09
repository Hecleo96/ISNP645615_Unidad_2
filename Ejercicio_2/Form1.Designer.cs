namespace Ejercicio_2
{
    partial class ConversorLongForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversorLongForms));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbdestino = new System.Windows.Forms.ComboBox();
            this.texCant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConver = new System.Windows.Forms.Button();
            this.texReslut = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(128, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos al conversor de Longitud";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.AllowDrop = true;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(128, 300);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 1;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // cmbdestino
            // 
            this.cmbdestino.FormattingEnabled = true;
            this.cmbdestino.Location = new System.Drawing.Point(351, 300);
            this.cmbdestino.Name = "cmbdestino";
            this.cmbdestino.Size = new System.Drawing.Size(121, 21);
            this.cmbdestino.TabIndex = 2;
            this.cmbdestino.SelectedIndexChanged += new System.EventHandler(this.cmbdestino_SelectedIndexChanged);
            // 
            // texCant
            // 
            this.texCant.Location = new System.Drawing.Point(247, 228);
            this.texCant.Name = "texCant";
            this.texCant.Size = new System.Drawing.Size(121, 20);
            this.texCant.TabIndex = 4;
            this.texCant.TextChanged += new System.EventHandler(this.texCant_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(208, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese la cantidad a convertir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(174, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "De";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(401, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "A";
            // 
            // btnConver
            // 
            this.btnConver.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConver.ForeColor = System.Drawing.SystemColors.Info;
            this.btnConver.Location = new System.Drawing.Point(268, 360);
            this.btnConver.Name = "btnConver";
            this.btnConver.Size = new System.Drawing.Size(75, 23);
            this.btnConver.TabIndex = 8;
            this.btnConver.Text = "Convertir";
            this.btnConver.UseVisualStyleBackColor = false;
            this.btnConver.Click += new System.EventHandler(this.btnconver_Click);
            // 
            // texReslut
            // 
            this.texReslut.Location = new System.Drawing.Point(247, 439);
            this.texReslut.Name = "texReslut";
            this.texReslut.Size = new System.Drawing.Size(121, 20);
            this.texReslut.TabIndex = 9;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.Info;
            this.btnclear.Location = new System.Drawing.Point(268, 476);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Limpiar";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(529, 592);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(271, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Resultado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ConversorLongForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.texReslut);
            this.Controls.Add(this.btnConver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texCant);
            this.Controls.Add(this.cmbdestino);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConversorLongForms";
            this.Text = "Conversor UGB";
            this.Load += new System.EventHandler(this.ConversorLongForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbdestino;
        private System.Windows.Forms.TextBox texCant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConver;
        private System.Windows.Forms.TextBox texReslut;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

