using CalculadoraAmbienta.Modelos;
using CalculadoraAmbienta.Servicios;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraAmbienta.PantallaReportes
{
    public partial class Reportes : Form
    {
        private readonly PantallaService _service;
        private readonly ExcelService _excelService;

        public Reportes(PantallaService service, ExcelService excelService)
        {
            InitializeComponent();
            _service = service;
            _excelService = excelService;
            this.WindowState = FormWindowState.Maximized;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            //Aquí carga los filtros de año y mes
            crearListadoCheckBoxesAnio();
            crearListadoCheckBoxesMes();
            cargarColumnas();
        }

        private void cargarColumnas()
        {
            uiDataGridView1.AddColumn("Id", "id", 50);
            uiDataGridView1.AddColumn("Año", "anio", 55);
            uiDataGridView1.AddColumn("Mes", "mes", 55);

            uiDataGridView1.AddColumn("Papel", "papel", 70);
            uiDataGridView1.AddColumn("Plástico", "plastico", 75);
            uiDataGridView1.AddColumn("Aluminio", "aluminio", 75);
            uiDataGridView1.AddColumn("Vidrio", "vidrio", 70);
            uiDataGridView1.AddColumn("Electrónica", "electronica", 80);

            uiDataGridView1.AddColumn("Árboles", "arboles", 70);
            uiDataGridView1.AddColumn("Agua", "agua", 70);
            uiDataGridView1.AddColumn("Energía", "energia", 75);
            uiDataGridView1.AddColumn("Relleno", "relleno", 80);
            uiDataGridView1.AddColumn("CO₂", "co2", 60);
            uiDataGridView1.AddColumn("Petróleo", "petroleo", 75);
            uiDataGridView1.AddColumn("Bauxita", "bauxita", 70);

            uiDataGridView1.EnableHeadersVisualStyles = false;

            uiDataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(57, 131, 48);

            uiDataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            uiDataGridView1.ClearRows();

            var reporteCompleto = obtenerReporteCompleto();

            crearRowsEnTablas(reporteCompleto);

        }

        private void downloadExcel_Click(object sender, EventArgs e)
        {
            var reporteCompleto = obtenerReporteCompleto();

            var archivo = _excelService.crearReporteExcelPrincipal(reporteCompleto);

            using var dialog = new SaveFileDialog
            {
                Filter = "Archivo Excel (*.xlsx)|*.xlsx",
                FileName = "Reportes.xlsx",
                Title = "Guardar reporte"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(dialog.FileName, archivo);
            }
        }

        public List<ReporteTablas> obtenerReporteCompleto()
        {
            List<string> anios = new List<string>();
            List<string> meses = new List<string>();
            List<ReporteTablas> listaReporteTabla = new List<ReporteTablas>();

            //año
            foreach (string anio in uiCheckBoxGroup1.SelectedItems)
            {
                anios.Add(anio);
            }

            // Mes
            foreach (string mes in uiCheckBoxGroup2.SelectedItems)
            {
                meses.Add(mes);
            }

            //Los meses vienen del listado de filtros por los nombres de los meses en una lista
            //Enero, Febrero, Marzo...
            //Este método los transforma a numeros como vienen en sql
            //01, 02, 03...
            var mesesTraducidos = PantallaService.traducirMesesANumeros(meses);

            var reportes = _service.getReportes(anios, mesesTraducidos).ToList();

            //Obtiene el resultado de los inputs al hacer las operaciones correspondientes
            var reportesCalculados = calcularReportesTabla(reportes.ToList());

            //itera sobre los reportes y crea un objeto que junta tanto los reportes guardados en  sql
            //como los resultados de las operaciones a partir de ese reporte
            //para posteriormente usarlos como las filas de las tablas
            for (int i = 0; i < reportes.Count; i++)
            {
                var reporte = reportes[i];
                var resultado = reportesCalculados[i];
                //saca el numero del mes de la fecha de BD
                var mesDeFecha = reportes[i].Fecha?.Substring(5, 2);
                List<string> listaMes = new List<string>();
                // crea la lista del mes ( el método solo admite lista así que por eso se conviierte jeje)
                listaMes.Add(mesDeFecha);
                // obtienes el mes convertido a string (Enero, febrero...)
                var mes = PantallaService.traducirNumerosAMeses(listaMes);
                Console.WriteLine(mes);

                var reporteTabla = new ReporteTablas
                {
                    IdReporte = reporte.Id_Reporte,
                    Anio = reporte.Fecha?.Substring(0, 4),
                    Mes = mes[0],
                    Papel = reporte.Papel,
                    Plastico = reporte.Plastico,
                    Aluminio = reporte.Aluminio,
                    Vidrio = reporte.Vidrio,
                    Electronica = reporte.Electronica,
                    Arboles = resultado.Arboles,
                    Agua = resultado.Agua,
                    Energia = resultado.Energia,
                    RellenoSanitario = resultado.RellenoSanitario,
                    CO2 = resultado.CO2,
                    Petroleo = resultado.Petroleo,
                    Bauxita = resultado.Bauxita
                };

                listaReporteTabla.Add(reporteTabla);
            }
            return listaReporteTabla;
        }

        private List<Resultados> calcularReportesTabla(List<Reporte> reportes)
        {
            List<Resultados> reportesCalculados = new List<Resultados>();

            foreach (var reporte in reportes)
            {
                Resultados resultado = PantallaService.calculadora(reporte);

                reportesCalculados.Add(resultado);
            }

            return reportesCalculados;
        }

        private void crearRowsEnTablas(List<ReporteTablas> listaReportesTabla)
        {
            foreach (var listaReporte in listaReportesTabla)
            {
                uiDataGridView1.AddRow(
                     listaReporte.IdReporte,
                     listaReporte.Anio,
                     listaReporte.Mes,
                     listaReporte.Papel,
                     listaReporte.Plastico,
                     listaReporte.Aluminio,
                     listaReporte.Vidrio,
                     listaReporte.Electronica,
                     listaReporte.Arboles,
                     listaReporte.Agua,
                     listaReporte.Energia,
                     listaReporte.RellenoSanitario,
                     listaReporte.CO2,
                     listaReporte.Petroleo,
                     listaReporte.Bauxita
                 );
            }
            uiDataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            uiDataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void crearListadoCheckBoxesAnio()
        {

            //Los filtros de mes son estáticos, sin embargo, para los de año se tomó la decisión de
            //Consultar la BD para saber cuales son los años en los registros y usar esos
            var anios = _service.getAnios();

            List<string> aniosSinRepetir = anios.Distinct().ToList();

            foreach (var anio in aniosSinRepetir)
            {
                uiCheckBoxGroup1.Items.Add(anio);
            }
            ;
        }

        private void crearListadoCheckBoxesMes()
        {
            List<string> meses = [
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"];

            foreach (var mes in meses)
            {
                uiCheckBoxGroup2.Items.Add(mes);
            }
            ;
        }

        private void uiCheckBoxGroup2_ValueChanged(object sender, Sunny.UI.CheckBoxGroupEventArgs e)
        {

        }

        private void uiCheckBoxGroup1_ValueChanged(object sender, CheckBoxGroupEventArgs e)
        {

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
