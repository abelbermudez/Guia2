using Clase_practica.Entindades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_practica.Servicios
{
    internal class Ventaservice
    {
        public async Task<string> ProcesarVentasAsync(List<ventas> ventas)

        {

            return await Task.Run(() =>

            {

                StringBuilder sb = new StringBuilder();



                decimal totalVendido = ventas.AsParallel().Sum(v => v.Total);
               

                decimal promedio = ventas.AsParallel().Average(v => v.Total);

                ventas ventaMayor = ventas.AsParallel()

                                         .OrderByDescending(v => v.Total)

                                         .FirstOrDefault();



                var agrupadas = ventas.AsParallel()

                                      .GroupBy(v => v.Categoria)

                                      .Select(g => new

                                      {

                                          Categoria = g.Key,

                                          TotalCategoria = g.Sum(x => x.Total),

                                          CantidadVentas = g.Count()

                                      })

                                      .ToList();



                sb.AppendLine("===== REPORTE DE VENTAS =====");

                sb.AppendLine($"Total vendido: {totalVendido:C}");
             

                sb.AppendLine($"Promedio por venta: {promedio:C}");



                if (ventaMayor != null)

                {

                    sb.AppendLine($"Venta mayor: {ventaMayor.Producto} - {ventaMayor.Total:C}");
                 

                }



                sb.AppendLine();

                sb.AppendLine("Ventas por categoría:");



                foreach (var item in agrupadas)

                {

                    sb.AppendLine($"- {item.Categoria}: {item.TotalCategoria:C} en {item.CantidadVentas} ventas");

                }



                return sb.ToString();

            });

        }
    }
}
