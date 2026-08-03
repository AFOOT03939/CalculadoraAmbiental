using CalculadoraAmbienta.Handlers;
using CalculadoraAmbienta.Modelos;
using CalculadoraAmbienta.PantallaReportes;
using CalculadoraAmbienta.Repositorios;
using CalculadoraAmbiental.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraAmbienta.Servicios
{
    public class PantallaService
    {

        private RepositorioReportes _reporte;

        public PantallaService(RepositorioReportes reportes)
        {
            _reporte = reportes;
        }

        public static Resultados calculadora(Reporte reporte)
        {
            // Papel
            var papelArboles = reporte.Papel * FactoresAmbientales.papelArboles;
            var papelAgua = reporte.Papel * FactoresAmbientales.papelAgua;
            var papelEnergia = reporte.Papel * FactoresAmbientales.papelEnergia;
            var papelRellenoSanitario = reporte.Papel * FactoresAmbientales.papelRellenoSanitario;
            var papelCo2 = reporte.Papel * FactoresAmbientales.papelCo2;
            var papelPetroleo = reporte.Papel * FactoresAmbientales.papelPetroleo;
            var papelBauxita = reporte.Papel * FactoresAmbientales.papelBauxita;

            // Plástico
            var plasticoArboles = reporte.Plastico * FactoresAmbientales.plasticoArboles;
            var plasticoAgua = reporte.Plastico * FactoresAmbientales.plasticoAgua;
            var plasticoEnergia = reporte.Plastico * FactoresAmbientales.plasticoEnergia;
            var plasticoRellenoSanitario = reporte.Plastico * FactoresAmbientales.plasticoRellenoSanitario;
            var plasticoCo2 = reporte.Plastico * FactoresAmbientales.plasticoCo2;
            var plasticoPetroleo = reporte.Plastico * FactoresAmbientales.plasticoPetroleo;
            var plasticoBauxita = reporte.Plastico * FactoresAmbientales.plasticoBauxita;

            // Aluminio
            var aluminioArboles = reporte.Aluminio * FactoresAmbientales.aluminioArboles;
            var aluminioAgua = reporte.Aluminio * FactoresAmbientales.aluminioAgua;
            var aluminioEnergia = reporte.Aluminio * FactoresAmbientales.aluminioEnergia;
            var aluminioRellenoSanitario = reporte.Aluminio * FactoresAmbientales.aluminioRellenoSanitario;
            var aluminioCo2 = reporte.Aluminio * FactoresAmbientales.aluminioCo2;
            var aluminioPetroleo = reporte.Aluminio * FactoresAmbientales.aluminioPetroleo;
            var aluminioBauxita = reporte.Aluminio * FactoresAmbientales.aluminioBauxita;

            // Vidrio
            var vidrioArboles = reporte.Vidrio * FactoresAmbientales.vidrioArboles;
            var vidrioAgua = reporte.Vidrio * FactoresAmbientales.vidrioAgua;
            var vidrioEnergia = reporte.Vidrio * FactoresAmbientales.vidrioEnergia;
            var vidrioRellenoSanitario = reporte.Vidrio * FactoresAmbientales.vidrioRellenoSanitario;
            var vidrioCo2 = reporte.Vidrio * FactoresAmbientales.vidrioCo2;
            var vidrioPetroleo = reporte.Vidrio * FactoresAmbientales.vidrioPetroleo;
            var vidrioBauxita = reporte.Vidrio * FactoresAmbientales.vidrioBauxita;

            // Electrónicos
            var electronicosArboles = reporte.Electronica * FactoresAmbientales.electronicosArboles;
            var electronicosAgua = reporte.Electronica * FactoresAmbientales.electronicosAgua;
            var electronicosEnergia = reporte.Electronica * FactoresAmbientales.electronicosEnergia;
            var electronicosRellenoSanitario = reporte.Electronica * FactoresAmbientales.electronicosRellenoSanitario;
            var electronicosCo2 = reporte.Electronica * FactoresAmbientales.electronicosCo2;
            var electronicosPetroleo = reporte.Electronica * FactoresAmbientales.electronicosPetroleo;
            var electronicosBauxita = reporte.Electronica * FactoresAmbientales.electronicosBauxita;

            // Calcula la sumatoria de los resultados de todos los inputs por sus constantes
            var sumatoriaArboles = papelArboles + plasticoArboles + aluminioArboles + vidrioArboles + electronicosArboles;
            var sumatoriaAgua = papelAgua + plasticoAgua + aluminioAgua + vidrioAgua + electronicosAgua;
            var sumatoriaEnergia = papelEnergia + plasticoEnergia + aluminioEnergia + vidrioEnergia + electronicosEnergia;
            var sumatoriaRellenoSanitario = papelRellenoSanitario + plasticoRellenoSanitario + aluminioRellenoSanitario + vidrioRellenoSanitario + electronicosRellenoSanitario;
            var sumatoriaCo2 = papelCo2 + plasticoCo2 + aluminioCo2 + vidrioCo2 + electronicosCo2;
            var sumatoriaPetroleo = papelPetroleo + plasticoPetroleo + aluminioPetroleo + vidrioPetroleo + electronicosPetroleo;
            var sumatoriaBauxita = papelBauxita + plasticoBauxita + aluminioBauxita + vidrioBauxita + electronicosBauxita;

            // Objeto de resultados (es lo que irá al forms al terminar)
            var resultados = new Resultados{
                Arboles = sumatoriaArboles,
                Agua = sumatoriaAgua,
                Energia = sumatoriaEnergia,
                RellenoSanitario = sumatoriaRellenoSanitario,
                CO2 = sumatoriaCo2,
                Petroleo = sumatoriaPetroleo,
                Bauxita = sumatoriaBauxita
            };

            return resultados;

        }

        public bool setReporte(Reporte reporte)
        {
            var resultado = _reporte.setReporte(reporte);

            return resultado;
        }

        public IEnumerable<string> getAnios()
        {
            var resultado = _reporte.getAnios();

            return resultado;
        }

        public IEnumerable<Reporte> getReportes(List<string>? anios, List<string>? meses)
        {
            var resultado = _reporte.getReporte(anios, meses);

            return resultado;
        }

        public static List<string> traducirMeses(List<string> meses)
        {
            List<string> mesesTraducidos = new List<string>();

            foreach (var mes in meses)
            {
                switch (mes)
                {
                    case "Enero":
                        mesesTraducidos.Add("01");
                        break;

                    case "Febrero":
                        mesesTraducidos.Add("02");
                        break;

                    case "Marzo":
                        mesesTraducidos.Add("03");
                        break;

                    case "Abril":
                        mesesTraducidos.Add("04");
                        break;

                    case "Mayo":
                        mesesTraducidos.Add("05");
                        break;

                    case "Junio":
                        mesesTraducidos.Add("06");
                        break;

                    case "Julio":
                        mesesTraducidos.Add("07");
                        break;

                    case "Agosto":
                        mesesTraducidos.Add("08");
                        break;

                    case "Septiembre":
                        mesesTraducidos.Add("09");
                        break;

                    case "Octubre":
                        mesesTraducidos.Add("10");
                        break;

                    case "Noviembre":
                        mesesTraducidos.Add("11");
                        break;

                    case "Diciembre":
                        mesesTraducidos.Add("12");
                        break;
                }
            }

            return mesesTraducidos;
        }
    }
}
