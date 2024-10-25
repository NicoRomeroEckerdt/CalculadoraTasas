
using System;
using System.Windows.Forms;

namespace CalculadoraTasasInteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables de entrada
                double capital = Convert.ToDouble(txtCapital.Text);
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFinal = dtpFechaFinal.Value;
                TimeSpan diferenciaFechas = fechaFinal - fechaInicio;

                // Obtener la tasa seleccionada
                string tipoTasa = cmbTipoTasa.SelectedItem.ToString();
                double tasaInteres = 0;

                // Asignar la tasa según la selección
                if (tipoTasa == "Mensual")
                {
                    tasaInteres = 0.25; // Tasa del 25% mensual
                }
                else if (tipoTasa == "Semanal")
                {
                    tasaInteres = 0.05; // Tasa del 5% semanal
                }
                else if (tipoTasa == "Diaria")
                {
                    tasaInteres = 0.005; // Tasa del 0.5% diaria
                }

                // Calcular la cantidad de periodos (días, semanas o meses) entre las fechas
                int cantidadPeriodos = 0;

                if (tipoTasa == "Mensual")
                {
                    cantidadPeriodos = (int)(diferenciaFechas.Days / 30); // Aproximado en meses
                }
                else if (tipoTasa == "Semanal")
                {
                    cantidadPeriodos = (int)(diferenciaFechas.Days / 7); // Semanas
                }
                else if (tipoTasa == "Diaria")
                {
                    cantidadPeriodos = diferenciaFechas.Days; // Días
                }

                // Calcular el interés usando interés compuesto
                double resultado = capital * Math.Pow((1 + tasaInteres), cantidadPeriodos);

                lblResultado.Text = "El valor final es: " + resultado.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingresa valores válidos: " + ex.Message);
            }
        }
    }
}
