using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace CalculadoraTasas
{
    public partial class Form1 : Form
    {
        float montoTotal = 0;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600); // Tamaño más pequeño por defecto
        }
        private void cbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMoneda.Items.Add("Peso");
            cbMoneda.Items.Add("Dólar");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            if (endDate < startDate)
            {
                lblDaysDifference.Text = "La fecha de finalización no puede ser anterior a la fecha de inicio.";
            }
            else
            {
                TimeSpan difference = endDate - startDate;
                lblDaysDifference.Text = $"Días entre fechas: {difference.Days + 1}";
            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            if (endDate < startDate)
            {
                lblDaysDifference.Text = "La fecha de finalización no puede ser anterior a la fecha de inicio.";
            }
            else
            {
                TimeSpan difference = endDate - startDate;
                lblDaysDifference.Text = $"Días entre fechas: {difference.Days + 1}"; // +1 para incluir ambas fechas
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validar si se seleccionó "Peso" o "Dólar" en el ComboBox
            string selectedCurrency = cbMoneda.SelectedItem.ToString();
            float monto = float.Parse(txtMontoInicial.Text);

            // Obtener el número de días desde el lblDaysDifference
            int contaD;
            if (!int.TryParse(lblDaysDifference.Text.Replace("Días entre fechas: ", ""), out contaD))
            {
                MessageBox.Show("No se ha calculado la diferencia de días correctamente.");
                return;
            }

            if (selectedCurrency == "Peso")
            {
                // Tasas para Peso
                float mensualPeso = 0.25f;
                float semanalPeso = 0.05f;
                float diarioPeso = 0.005f;

                if (rbtnMensual.Checked)
                {
                    float mon = monto;
                    monto += (mensualPeso * monto);
                    ListViewItem item = new ListViewItem("$ " + mon.ToString("N0") + " + 25% = $ " + monto.ToString("N0"));
                    listViewResultados.Items.Add(item);
                    

                }
                else if (rbtnSin.Checked)
                {
                    monto = monto - 0;
                }
                else if (rbtnSemanal.Checked)
                {
                    int semanas = contaD / 7;
                    float acu = monto;

                    for (int i = 0; i < semanas; i++)
                    {
                        acu = monto;
                        acu += (semanalPeso * acu);
                        ListViewItem item = new ListViewItem("$ " + monto.ToString("N0") + " + 5% = $ " + acu.ToString("N0"));
                        listViewResultados.Items.Add(item);
                        monto = acu;
                    }
                    monto = acu;
                }
                else if (rbtnDiario.Checked)
                {
                    float montoto = monto;
                   
                    monto += (contaD * diarioPeso * monto);
                    string valorPorcentaje = (diarioPeso * 100).ToString("0.##") + "%";
                    string conta = contaD.ToString();
                    ListViewItem item = new ListViewItem("$ " + montoto.ToString("N0") + " + (" + conta + " x " + valorPorcentaje + ") = $ " + monto.ToString("N0"));
                    listViewResultados.Items.Add(item);
                }

                txtbResultado.Text = monto.ToString("N0");
            }
            else if (selectedCurrency == "Dólar")
            {
                rbtnSemanal.Enabled = false;
                rbtnSemanal.Visible = false;

                // Tasas para Dólar según el monto
                float tasaMensual;
                float tasaDiaria = 0.0025f; // 0.25% diaria

                if (monto < 5000)
                {
                    tasaMensual = 0.12f; // 12%
                }
                else if (monto < 10000)
                {
                    tasaMensual = 0.13f; // 13%
                }
                else if (monto < 20000)
                {
                    tasaMensual = 0.14f; // 14%
                }
                else
                {
                    tasaMensual = 0.15f; // 15%
                }

                if (rbtnMensual.Checked)
                {
                    float montote = monto;
                    string valorPorcen = (tasaMensual * 100).ToString("0.##") + "%";
                    monto += (tasaMensual * monto);

                    ListViewItem item = new ListViewItem("U$D " + montote.ToString("N0") + " + " + valorPorcen + " = U$D " + monto.ToString("N0"));
                    listViewResultados.Items.Add (item);
                    
                }
                else if (rbtnDiario.Checked)
                {
                    float mont = monto;
                    monto += (contaD * tasaDiaria * monto);
                    string valorPorc = (tasaDiaria * 100).ToString("0.##") + "%";
                    string conta = contaD.ToString();



                    ListViewItem item = new ListViewItem("U$D " + mont.ToString("N0") + " + (" + conta + " x " + valorPorc + ") = U$D " + monto.ToString("N0"));
                    listViewResultados.Items.Add(item);
                }

                txtbResultado.Text = monto.ToString("N0");
            }
            else
            {
                MessageBox.Show("Seleccione una moneda válida.");
            }

        }


        private void txtMontoInicial_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtMontoInicial.SelectionStart;
            string textoSinPuntos = txtMontoInicial.Text.Replace(".", "");

            if (long.TryParse(textoSinPuntos, out long numero))
            {
                txtMontoInicial.Text = numero.ToString("N0");
                txtMontoInicial.SelectionStart = cursorPosition + (txtMontoInicial.Text.Length - textoSinPuntos.Length);
            }
            else
            {
                txtMontoInicial.Text = textoSinPuntos;
            }
        }
        private float montoSumar = 0; // Variable para almacenar el monto acumulado
        private float segundoResultado = 0; // Variable para almacenar el nuevo monto tras la suma


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (rbtnAgregar.Checked)
            {
                // Guardar el valor actual de txtbResultado en montoSumar
                if (float.TryParse(txtbResultado.Text, out float resultadoActual))
                {
                    montoSumar += resultadoActual;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido.");
                    return;
                }

                // Limpiar txtMontoInicial y txtbResultado
                txtMontoInicial.Clear();
                txtbResultado.Clear();

                // Deshabilitar rbtnMensual y rbtnSemanal, solo permitir rbtnDiario
                rbtnMensual.Enabled = false;
                rbtnSemanal.Enabled = false;
                rbtnDiario.Enabled = true;
                rbtnSin.Enabled = true;

                // Habilitar el botón "btnSumar"
                btnSumar.Visible = true;
                btnSumar.Enabled = true;

                MessageBox.Show("Ingrese el monto a sumar en MONTO INICIAL, luego elija si ese monto rendirá a tasa diaria algunos días ( En este caso selecione la cantidad de días y selecione DIARIO). Si se sumará un monto sin rendir elija SIN RENDICION. Luego presione el botón CALCULAR y finalice el calculo presionando el botón SUMAR.");

                // Mostrar en la ListView el cálculo anterior y el montoSumar
             //ListViewItem item = new ListViewItem("Calculo: " + montoSumar + " + " + txtbResultado.Text + " = " + (montoSumar + txtbResultado.Text));
              //listViewResultados.Items.Add(item);
              
            }
            else if (rbtnExtraer.Checked)
            {
                // Guardar el valor actual de txtbResultado en montoSumar
                if (float.TryParse(txtbResultado.Text, out float resultadoActual))
                {
                    montoSumar += resultadoActual;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido.");
                    return;
                }

                // Limpiar txtMontoInicial y txtbResultado
                txtMontoInicial.Clear();
                txtbResultado.Clear();

                // Deshabilitar rbtnMensual y rbtnSemanal, solo permitir rbtnDiario
                rbtnMensual.Enabled = false;
                rbtnSemanal.Enabled = false;
                rbtnDiario.Enabled = true;
                rbtnSin.Enabled = true;
                btnSumar.Enabled = false;

                // Habilitar el botón "btnRestar"
                btnRestar.Visible = true;
                btnRestar.Enabled = true;


                MessageBox.Show("Introduzca el monto a extraer en MONTO INICIAL, seleccione la opción SIN RENDICIÓN, presione el botón CALCULAR y luego presione el botón RESTAR.");

            }
            else if (rbtnFinalizar.Checked)
            {
                // Limpiar todos los campos y permitir volver a usar el formulario
                txtMontoInicial.Clear();
                txtbResultado.Clear();
                listViewResultados.Items.Clear();
                montoSumar = 0;

                // Habilitar todos los radio buttons nuevamente
                rbtnMensual.Enabled = true;
                rbtnSemanal.Enabled = true;
                rbtnDiario.Enabled = true;
                btnSumar.Visible = false;
                btnRestar .Visible = false;
                btnRestar.Enabled = false;
                btnSumar.Enabled = false;

                MessageBox.Show("Los campos se han limpiado. Puede comenzar de nuevo.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una opción.");
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string moneSelec = cbMoneda.SelectedItem.ToString();
            // Guardar el nuevo valor de txtbResultado en la variable segundoResultado
            if (float.TryParse(txtbResultado.Text, out float nuevoResultado))
            {
                segundoResultado = nuevoResultado;
                float total = montoSumar + segundoResultado;

                // Mostrar la suma en la ListView si es en pesos
                if (moneSelec == "Peso")
                {
                    ListViewItem item = new ListViewItem("$ " + montoSumar.ToString("N0") + " + $ " + nuevoResultado.ToString("N0") + " = $ " + total.ToString("N0"));
                    listViewResultados.Items.Add(item);
                }
                // ,ostrar la suma en la List View si es en Dolares
                else if (moneSelec == "Dólar")
                {
                    ListViewItem item = new ListViewItem("U$D " + montoSumar.ToString("N0") + " + U$D " + nuevoResultado.ToString("N0") + " = U$D " + total.ToString("N0"));
                    listViewResultados.Items.Add(item);
                }
               

                // Actualizar montoSumar para que sea el nuevo total
                montoSumar = total;

                // Limpiar el txtbResultado para un posible nuevo cálculo
                txtbResultado.Clear();
            }
            else
            {
                MessageBox.Show("El valor ingresado no es válido.");
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            string moneSelec = cbMoneda.SelectedItem.ToString();
            // Guardar el nuevo valor de txtbResultado en la variable segundoResultado
            if (float.TryParse(txtbResultado.Text, out float nuevoResultado))
            {
                segundoResultado = nuevoResultado;
                float total = montoSumar - segundoResultado;

                // Mostrar la resta en la ListView si es en pesos
                if (moneSelec == "Peso")
                {
                    ListViewItem item = new ListViewItem("$ " + montoSumar.ToString("N0") + " - $ " + nuevoResultado.ToString("N0") + " = $ " + total.ToString("N0"));
                    listViewResultados.Items.Add(item);
                }
                // ,ostrar la resta en la List View si es en Dolares
                else if (moneSelec == "Dólar")
                {
                    ListViewItem item = new ListViewItem("U$D " + montoSumar.ToString("N0") + " - U$D " + nuevoResultado.ToString("N0") + " = U$D " + total.ToString("N0"));
                    listViewResultados.Items.Add(item);
                }

                // Actualizar montoSumar para que sea el nuevo total
                montoSumar = total;

                // Limpiar el txtbResultado para un posible nuevo cálculo
                txtbResultado.Clear();
            }
            else
            {
                MessageBox.Show("El valor ingresado no es válido.");
            }
        }
    }
}
