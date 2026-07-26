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
        public Calculadora()
        {
            InitializeComponent();
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


            output1.Text = papel;
            output2.Text = plastico;
            output3.Text = aluminio;
            output4.Text = vidrio;
            output5.Text = electronicos;

        }

    }
}
