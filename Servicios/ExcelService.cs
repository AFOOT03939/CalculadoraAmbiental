using CalculadoraAmbienta.Modelos;
using SlapKit.Excel.Excel;
using SlapKit.Excel.Excel.Charts.ChartTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraAmbienta.Servicios
{
    public class ExcelService
    {
        public byte[] crearReporteExcelPrincipal(List<ReporteTablas> reporteCompleto)
        {
            using XLWorkbook workbook = new XLWorkbook();

            var worksheet = workbook.Worksheets.Add("Reporte");

            worksheet.Cell(1, 1).InsertTable(reporteCompleto);

            int filaTotal = 0;

            if (reporteCompleto.Count > 0)
            {
                //fila total es donde se va a encontrar la fila del total
                //le sumamos +2 para tomar en cuenta el encabezado
                //1 para el encabezado, 2 para la nueva fila
                //si son 5 registros, quedan 7 al final
                filaTotal = reporteCompleto.Count + 2;

                worksheet.Cell(filaTotal, 3).Value = "TOTAL";

                //se calcula el total, D2 es el primer registro y total - 1 para ignorar la fila del total
                worksheet.Cell(filaTotal, 4).FormulaA1 = $"=SUM(D2:D{filaTotal - 1})"; // Papel
                worksheet.Cell(filaTotal, 5).FormulaA1 = $"=SUM(E2:E{filaTotal - 1})"; // Cartón
                worksheet.Cell(filaTotal, 6).FormulaA1 = $"=SUM(F2:F{filaTotal - 1})"; // Plástico
                worksheet.Cell(filaTotal, 7).FormulaA1 = $"=SUM(G2:G{filaTotal - 1})"; // Aluminio
                worksheet.Cell(filaTotal, 8).FormulaA1 = $"=SUM(H2:H{filaTotal - 1})"; // Vidrio
                worksheet.Cell(filaTotal, 9).FormulaA1 = $"=SUM(I2:I{filaTotal - 1})"; // Electrónica
                worksheet.Cell(filaTotal, 10).FormulaA1 = $"=SUM(J2:J{filaTotal - 1})";
                worksheet.Cell(filaTotal, 11).FormulaA1 = $"=SUM(K2:K{filaTotal - 1})";
                worksheet.Cell(filaTotal, 12).FormulaA1 = $"=SUM(L2:L{filaTotal - 1})";
                worksheet.Cell(filaTotal, 13).FormulaA1 = $"=SUM(M2:M{filaTotal - 1})";
                worksheet.Cell(filaTotal, 14).FormulaA1 = $"=SUM(N2:N{filaTotal - 1})";
                worksheet.Cell(filaTotal, 15).FormulaA1 = $"=SUM(O2:O{filaTotal - 1})";
                worksheet.Cell(filaTotal, 16).FormulaA1 = $"=SUM(P2:P{filaTotal - 1})";

                worksheet.Range(filaTotal, 3, filaTotal, 16).Style.Font.Bold = true;

                // Gráfico de los inputs
                //esto define la posición del gráfico
                IXLBarChart barChartInputs = worksheet.Charts
                    .AddBarChart()
                    .MoveTo(
                        fromCell: worksheet.Cell($"B{filaTotal + 2}"),
                        toCell: worksheet.Cell($"P{filaTotal + 14}")
                    );

                //esto define las categorías y sus valores (50L de agua...)
                barChartInputs.Series.Add()
                    .SetName("Total de Entradas de Materiales")
                    .SetCategories(worksheet.Range("D1:I1"))
                    .SetValues(worksheet.Range($"D{filaTotal}:H{filaTotal}"));

                // Gráfico de los outputs
                IXLBarChart barChartOutputs = worksheet.Charts
                    .AddBarChart()
                    .MoveTo(
                        fromCell: worksheet.Cell($"B{filaTotal + 16}"),
                        toCell: worksheet.Cell($"P{filaTotal + 28}")
                    );

                barChartOutputs.Series.Add()
                    .SetName("Total de Material Reciclado")
                    .SetCategories(worksheet.Range("I1:P1"))
                    .SetValues(worksheet.Range($"I{filaTotal}:O{filaTotal}"));
            }

            worksheet.Columns().AdjustToContents();

            using var stream = new MemoryStream();

            workbook.SaveAs(stream);

            return stream.ToArray();
        }
    }
}
