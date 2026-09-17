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

            if (reporteCompleto.Count > 0)
            {
                int filaTotal = reporteCompleto.Count + 2;

                worksheet.Cell(filaTotal, 3).Value = "TOTAL";

                worksheet.Cell(filaTotal, 4).FormulaA1 = $"=SUM(D2:D{filaTotal - 1})";
                worksheet.Cell(filaTotal, 5).FormulaA1 = $"=SUM(E2:E{filaTotal - 1})";
                worksheet.Cell(filaTotal, 6).FormulaA1 = $"=SUM(F2:F{filaTotal - 1})";
                worksheet.Cell(filaTotal, 7).FormulaA1 = $"=SUM(G2:G{filaTotal - 1})";
                worksheet.Cell(filaTotal, 8).FormulaA1 = $"=SUM(H2:H{filaTotal - 1})";
                worksheet.Cell(filaTotal, 9).FormulaA1 = $"=SUM(I2:I{filaTotal - 1})";
                worksheet.Cell(filaTotal, 10).FormulaA1 = $"=SUM(J2:J{filaTotal - 1})";
                worksheet.Cell(filaTotal, 11).FormulaA1 = $"=SUM(K2:K{filaTotal - 1})";
                worksheet.Cell(filaTotal, 12).FormulaA1 = $"=SUM(L2:L{filaTotal - 1})";
                worksheet.Cell(filaTotal, 13).FormulaA1 = $"=SUM(M2:M{filaTotal - 1})";
                worksheet.Cell(filaTotal, 14).FormulaA1 = $"=SUM(N2:N{filaTotal - 1})";
                worksheet.Cell(filaTotal, 15).FormulaA1 = $"=SUM(O2:O{filaTotal - 1})";

                worksheet.Range(filaTotal, 3, filaTotal, 15).Style.Font.Bold = true;
            }

            worksheet.Columns().AdjustToContents();

            using var stream = new MemoryStream();

            workbook.SaveAs(stream);

            return stream.ToArray();
        }
    }
}
