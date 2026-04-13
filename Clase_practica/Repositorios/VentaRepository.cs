using Clase_practica.Entindades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace Clase_practica.Repositorios
{
    public class VentaRepository: Iventasrepository
    {
        public async Task<List<ventas>> ObtenerVentasAsync()

        {

            await Task.Delay(2000);



            return new List<ventas>

         {

             new ventas { Id  = 1, Producto = "Laptop", Categoria = "Tecnología", Cantidad = 2, PrecioUnitario = 550m, Fecha = DateTime.Now.AddDays(-1) },

             new ventas { Id = 2, Producto = "Mouse", Categoria = "Tecnología", Cantidad = 5, PrecioUnitario = 20m, Fecha = DateTime.Now.AddDays(-2) },

             new ventas { Id = 3, Producto = "Teclado", Categoria = "Tecnología", Cantidad = 3, PrecioUnitario = 35m, Fecha = DateTime.Now.AddDays(-3) },

             new ventas { Id = 4, Producto = "Silla", Categoria = "Oficina", Cantidad = 2, PrecioUnitario = 120m, Fecha = DateTime.Now.AddDays(-2) },

             new ventas { Id = 5, Producto = "Escritorio", Categoria = "Oficina", Cantidad = 1, PrecioUnitario = 250m, Fecha = DateTime.Now.AddDays(-4) },

             new ventas{ Id = 6, Producto = "Monitor", Categoria = "Tecnología", Cantidad = 4, PrecioUnitario = 180m, Fecha = DateTime.Now.AddDays(-1) }

         };

        }
    }
}
