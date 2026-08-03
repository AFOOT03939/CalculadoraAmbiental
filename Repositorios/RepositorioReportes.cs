using CalculadoraAmbienta.Handlers;
using CalculadoraAmbienta.Modelos;
using CalculadoraAmbienta.PantallaReportes;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraAmbienta.Repositorios
{
    public class RepositorioReportes
    {
        // Los repositorios utilizan Dapper, es una librería que me facilita usar código SQL en lugar de LINQ
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
                // Inserta la fecha de hoy
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


        public IEnumerable<Reporte> getReporte(List<string>? anios, List<string>? meses)
        {
            using var conexion = _conexion.CreateConnection();

            //Lista que contiene las condiciones
            var where = new List<string>();

            //si los parametros vienen con datos, se agregaran estos strings al where
            if (anios != null && anios.Any())
            {
                where.Add("substr(FECHA, 1, 4) IN @Anios");
            }

            if (meses != null && meses.Any())
            {
                where.Add("substr(FECHA, 6, 2) IN @Meses");
            }

            var sql = @"
                SELECT
                    ID_REPORTE,
                    FECHA,
                    PAPEL,
                    PLASTICO,
                    ALUMINIO,
                    VIDRIO,
                    ELECTRONICA
                FROM Reportes";

            if (where.Any())
            {
                //Esto construye los filtros del query
                //es un WHERE y si la lista where tiene mas de un elemento, se agrega un AND en medio
                //WHERE 1=1 AND 2=2 y así
                sql += " WHERE " + string.Join(" AND ", where);
            }

            //Estos son los parametros que se pasan a los strings de los filtros
            var parameters = new
            {
                Anios = anios,
                Meses = meses
            };

            return conexion.Query<Reporte>(sql, parameters);
        }

        public IEnumerable<string> getAnios()
        {

            using var conexion = _conexion.CreateConnection();

            var sql = @"
                SELECT 
                    SUBSTRING(FECHA, 1, 4)
                FROM Reportes
            ";

            var reportes = conexion.Query<string>(sql);

            return reportes;

        }

    }
}
