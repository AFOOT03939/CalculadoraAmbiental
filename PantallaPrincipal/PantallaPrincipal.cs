using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CalculadoraAmbienta.PantallaCalculadora;
using CalculadoraAmbienta.PantallaReportes;
using Microsoft.Extensions.DependencyInjection;

namespace CalculadoraAmbienta.PantallaPrincipal
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Estos son los métodos que navegan a las 2 secciones de la pagina

        private void button1_Click(object sender, EventArgs e)
        {
            var calculadora = Program.Services.GetRequiredService<Calculadora>();

            calculadora.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reportes = new Reportes();

            reportes.Show();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
