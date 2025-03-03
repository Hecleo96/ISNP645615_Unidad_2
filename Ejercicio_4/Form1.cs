﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000; // Esto es Igual a 1 segundo
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si los campos  de entrada están en blanco
            if (string.IsNullOrWhiteSpace(txtUnitario.Text) || string.IsNullOrWhiteSpace(txtCant.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución del método por dejar campos vacios
            }
            
            double Uni = double.Parse(txtUnitario.Text);
            int Cant = int.Parse(txtCant.Text);

            if (Uni == 0 || Cant == 0)
            {
                MessageBox.Show("No se puede calcular con cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el valor unitario ingresado por el usuario
            decimal vUnitario = decimal.Parse(txtUnitario.Text);

            // Obtener la cantidad ingresada por el usuario
            int cantidad = int.Parse(txtCant.Text);

            // Calcular el total sin descuento
            decimal totalSinDescu = CalTotalSinDescu(vUnitario, cantidad);

            // Calcular el descuento aplicado
            decimal descuento = CalcularDescuento(totalSinDescu);

            // Calcular el total a pagar con descuento
            decimal totalConDescu = totalSinDescu - descuento;

            // Mostrar el resultado en la etiqueta correspondiente separando por coma los miles
            txtTotalP.Text = "" + totalConDescu.ToString("#,##0.00");

            // Bloquear el campo de texto del monto a pagar para no modificar el valor final
            txtDescuento.ReadOnly = true;
            txtTotalP.ReadOnly = true;
        }

        // Método para calcular el total sin descuento
        private decimal CalTotalSinDescu(decimal valorUnitario, int cantidad)
        {
            return valorUnitario * cantidad;
        }

        // Método para calcular el descuento aplicado
        private decimal CalcularDescuento(decimal totalSinDescuento)
        {
            decimal descuento;
            if (totalSinDescuento < 20000)
            {
                descuento = totalSinDescuento * 0.15m; // 15% de descuento
                txtDescuento.Text = "15%";
            }
            else
            {
                descuento = totalSinDescuento * 0.35m; // 35% de descuento
                txtDescuento.Text = "35%";
            }
            return descuento;
        }
         

        // Método para calcular el total a pagar ya aplicando el respectivo descuento
        private decimal CalcularTotalPagar(decimal totalSinDescuento, decimal descuento)
        {
            return totalSinDescuento - descuento;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Con este podemos limpiar todos los textbox
            txtUnitario.Text = "";
            txtCant.Text = "";
            txtDescuento.Text = "";
            txtTotalP.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Este metodo sirve para cerrar la aplicación
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)

        {

            // Obtener la fecha y hora actual
            DateTime currentDateTime = DateTime.Now;

            // Mostrar la fecha y hora en un Label llamado "lblDateTime" en un formato específico
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedTime = currentDateTime.ToString("tt");
            // Obtener la hora actual sincronizada
            DateTime horaActual = DateTime.Now;
            
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el contenido del campo txtCant es un número entero
            if (!int.TryParse(txtCant.Text, out int cantidad))
            {
                // Mostrar mensaje de error si no es un número entero y eliminar el último carácter ingresado
                MessageBox.Show("Solo se pueden ingresar valores enteros en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCant.Text = txtCant.Text.Substring(0, txtCant.Text.Length - 1); // Eliminar el último carácter ingresado
                txtCant.SelectionStart = txtCant.Text.Length; // Colocar el cursor al final del texto
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}