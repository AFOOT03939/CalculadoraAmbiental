using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraAmbienta.Modelos
{
    public class ReporteTablas
    {
        public int IdReporte { get; set; }
        public string? Anio { get; set; }
        public double Papel { get; set; }
        public double Plastico { get; set; }
        public double Aluminio { get; set; }
        public double Vidrio { get; set; }
        public double Electronica { get; set; }
        public double Arboles { get; set; }
        public double Agua { get; set; }
        public double Energia { get; set; }
        public double RellenoSanitario { get; set; }
        public double CO2 { get; set; }
        public double Petroleo { get; set; }
        public double Bauxita { get; set; }
    }
}
