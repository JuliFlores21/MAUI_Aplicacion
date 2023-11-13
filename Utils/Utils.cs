﻿using MAUI_Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Aplicacion.Utils
{
    internal class Utils
    {
        public static List<Producto> ListaProducto = new List<Producto>()
        {
            new Producto()
            {
                IdProducto = 1,
                Nombre= "Producto 1",
                Descripcion="Descripcion",
                Cantidad=1
            },
            new Producto()
            {
                IdProducto = 2,
                Nombre= "Producto 2",
                Descripcion="Descripcion",
                Cantidad=2
            }
        };
    }
}
