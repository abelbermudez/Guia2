using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_practica.Repositorios
{
    public interface Iventasrepository
    {
        Task<List<Entindades.ventas>> ObtenerVentasAsync();
    }
}
