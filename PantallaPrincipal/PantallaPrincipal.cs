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
            this.WindowState = FormWindowState.Maximized;
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
            var reportes = Program.Services.GetRequiredService<Reportes>();

            reportes.Show();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            var reportes = Program.Services.GetRequiredService<Reportes>();

            reportes.Show();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            var calculadora = Program.Services.GetRequiredService<Calculadora>();

            calculadora.Show();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
