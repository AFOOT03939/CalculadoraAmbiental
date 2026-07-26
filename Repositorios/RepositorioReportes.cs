using CalculadoraAmbienta.Handlers;
using CalculadoraAmbienta.Modelos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraAmbienta.Repositorios
{
    internal class RepositorioReportes
    {

        private DapperHandler _conexion;

        public RepositorioReportes(DapperHandler conexion)
        {
           _conexion = conexion;
        }


        public bool setReporte(Reporte reporte)
        {

            using var conexion = _conexion.CreateConnection();

            var sql = @"
                INSERT INTO Reportes(fecha, papel, plastico, aluminio, vidrio, electronica)
                VALUES(@Fecha, @Papel, @Plastico, @Aluminio, @Vidrio, @Electronica);

            ";

            var parameters = new
            {
                Fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Papel = reporte.Papel,
                Plastico = reporte.Plastico,
                Aluminio = reporte.Aluminio,
                Vidrio = reporte.Vidrio,
                Electronica = reporte.Electronica
            };

            var result = conexion.Execute(sql, parameters);

            if(result == 0)
            {
                return false;
            }
            else
            {

                return true;
            }
        }


        public IEnumerable<Reporte> getReporte(string anio, string? mes)
        {

            using var conexion = _conexion.CreateConnection();

            var sql = @"
                SELECT 
                    FECHA,
                    PAPEL,
                    PLASTICO,
                    ALUMINIO,
                    VIDRIO,
                    ELECTRONICA
                FROM Reportes
                WHERE FECHA LIKE @Fecha
            ";

            var parameters = new
            {
                Fecha = string.IsNullOrEmpty(mes)
                    ? $"{anio}%"
                    : $"{anio}-{mes}%"
            };

            var reportes = conexion.Query<Reporte>(sql, parameters);

            return reportes;

        }

    }
}
