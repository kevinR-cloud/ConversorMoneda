using System;
using System.Windows.Forms;

namespace ConversorMoneda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarMonedas();
        }

        private void InicializarMonedas()
        {
            string[] monedas = { "DOP", "USD", "EUR" };
            cmbOrigen.Items.AddRange(monedas);
            cmbDestino.Items.AddRange(monedas);

            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMonto.Text, out double monto))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string de = cmbOrigen.SelectedItem.ToString();
            string a = cmbDestino.SelectedItem.ToString();

            double montoEnUSD = de switch
            {
                "DOP" => monto / 60.0,
                "EUR" => monto * 1.08,
                _ => monto
            };

            double resultado = a switch
            {
                "DOP" => montoEnUSD * 58.60,
                "EUR" => montoEnUSD / 1.08,
                _ => montoEnUSD
            };

            lblResultado.Text = $"Resultado: {resultado:N2} {a}";

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}