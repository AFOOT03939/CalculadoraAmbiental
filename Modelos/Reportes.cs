using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraAmbienta.Modelos
{
    public class Reporte
    {
        public string? Fecha { get; set; }
        public double Papel { get; set; }
        public double Plastico { get; set; }
        public double Aluminio { get; set; }
        public double Vidrio { get; set; }
        public double Electronica { get; set; }
    }
}
