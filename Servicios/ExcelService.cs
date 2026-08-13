using CalculadoraAmbienta.Modelos;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraAmbienta.Servicios
{
    public class ExcelService
    {
        public byte[] crearReporteExcelPrincipal(List<ReporteTablas> reporteCompleto)
        {
            using var workbook = new XLWorkbook();

            var worksheet = workbook.Worksheets.Add("Reporte");

            worksheet.Cell(1, 1).InsertTable(reporteCompleto);

            worksheet.Columns().AdjustToContents();

            using var stream = new MemoryStream();

            workbook.SaveAs(stream);

            return stream.ToArray();
        }
    }
}
