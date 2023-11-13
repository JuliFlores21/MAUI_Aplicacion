using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Aplicacion.Models
{
    class Producto
    {
        public int IdProducto { get; set; }
        [Required(ErrorMessage = "Escribe tu nombre")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Ingresa la cantidad")]
        public int Cantidad { get; set; }
    }
}
