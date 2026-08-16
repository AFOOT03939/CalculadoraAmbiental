using CalculadoraAmbienta.Modelos;
using CalculadoraAmbienta.PantallaReportes;
using CalculadoraAmbienta.Servicios;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraAmbienta.PantallaCalculadora
{
    public partial class Calculadora : Form
    {
        private readonly PantallaService _service;

        public Calculadora(PantallaService service)
        {
            InitializeComponent();
            _service = service;
            this.WindowState = FormWindowState.Maximized;
        }

        //son los inputs
        private void uiipTextBox1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uiipTextBox2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uiipTextBox3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uiipTextBox4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uiipTextBox5_ValueChanged(object sender, EventArgs e)
        {

        }

        //botón de submit para mandar los datos a calcular
        private void uiButton1_Click(object sender, EventArgs e)
        {

            string papel = input1.Text;
            string plastico = input2.Text;
            string aluminio = input3.Text;
            string vidrio = input4.Text;
            string electronicos = input5.Text;

            // se crea el objeto Reporte para enviarlo al servicio para calcular los outputs
            var objetoInputs = new Reporte
            {
                Papel = double.Parse(papel),
                Plastico = double.Parse(plastico),
                Aluminio = double.Parse(aluminio),
                Vidrio = double.Parse(vidrio),
                Electronica = double.Parse(electronicos)
            };

            Resultados resultado = PantallaService.calculadora(objetoInputs);

            // Aquí se muestran los resultados en los outputs del forms
            output1.Text = resultado.Arboles.ToString();
            output2.Text = resultado.Agua.ToString();
            output3.Text = resultado.Energia.ToString();
            output4.Text = resultado.CO2.ToString();
            output5.Text = resultado.Petroleo.ToString();
            output6.Text = resultado.RellenoSanitario.ToString();
            output7.Text = resultado.Bauxita.ToString();
        }

        private void output6_TextChanged(object sender, EventArgs e)
        {

        }

        private void output7_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            string papel = input1.Text;
            string plastico = input2.Text;
            string aluminio = input3.Text;
            string vidrio = input4.Text;
            string electronicos = input5.Text;

            // se crea el objeto Reporte para enviarlo al servicio para calcular los outputs
            var objetoInputs = new Reporte
            {
                Papel = double.Parse(papel),
                Plastico = double.Parse(plastico),
                Aluminio = double.Parse(aluminio),
                Vidrio = double.Parse(vidrio),
                Electronica = double.Parse(electronicos)
            };

            var resultadoQuery = _service.setReporte(objetoInputs);

            if (resultadoQuery)
            {
                MessageBox.Show("Reporte guardado con éxito");
            }
            else
            {
                MessageBox.Show("Error al guardar el reporte");
            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void output2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiButton1_Click_2(object sender, EventArgs e)
        {
            input1.Text = "0";
            input2.Text = "0";
            input3.Text = "0";
            input4.Text = "0";
            input5.Text = "0";

            output1.Text = "";
            output2.Text = "";
            output3.Text = "";
            output4.Text = "";
            output5.Text = "";
            output6.Text = "";
            output7.Text = "";
        }

        private void tableLayoutPanel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void output1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
