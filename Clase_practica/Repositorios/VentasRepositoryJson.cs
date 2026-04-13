using Clase_practica.Entindades;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
namespace Clase_practica.Repositorios
{
    public class VentasRepositoryJson : Iventasrepository
    {
        private readonly string rutarchivo = "ventas.json";

     
        public async Task ObtenerVentasAsync(List<ventas> listaVenta)
        {
            string json = JsonConvert.SerializeObject(listaVenta, Formatting.Indented);
            await File.WriteAllTextAsync(rutarchivo, json);
        }

        public Task<List<ventas>> ObtenerVentasAsync()
        {
            throw new NotImplementedException("No se usa deserialización.");
        }

    }
}



