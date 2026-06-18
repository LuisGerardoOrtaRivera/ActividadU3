using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormU3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ConversorDivisas conversor = new ConversorDivisas();
            string entrada = txtCantidad.Text;

            try
            {
                // Decidimos qué método de la sobrecarga usar según el formato de entrada
                if (entrada.Contains("."))
                {
                    double cantidadDouble = double.Parse(entrada);
                    double resultado = conversor.CalcularTotal(cantidadDouble); // Invoca Versión B

                    // Texto corto y limpio para que no sobrepase el ListBox
                    lstHistorial.Items.Add($"{cantidadDouble} USD = ${resultado:F2} MXN");
                }
                else
                {
                    int cantidadInt = int.Parse(entrada);
                    double resultado = conversor.CalcularTotal(cantidadInt); // Invoca Versión A

                    // Texto corto y limpio para que no sobrepase el ListBox
                    lstHistorial.Items.Add($"{cantidadInt} USD = ${resultado:F2} MXN");
                }

                txtCantidad.Clear();
                txtCantidad.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa una cantidad numérica válida.", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
