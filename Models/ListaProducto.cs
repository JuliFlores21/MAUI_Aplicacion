using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Aplicacion.Models
{
    internal class ListaProducto
    {
        public ObservableCollection<Producto> Productos { get; set; } = new ObservableCollection<Producto>();
        public void LoadProductos()
        {
            Productos.Clear();
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            IEnumerable<string> archivos = Directory.EnumerateFiles(appDataPath, "*.json");

            foreach (string archivo in archivos)
            {
                try
                {
                    // Lee el contenido del archivo
                    string contenido = File.ReadAllText(archivo);

                    // Deserializa el contenido del archivo a un objeto Producto
                    Producto producto = JsonConvert.DeserializeObject<Producto>(contenido);

                    // Agrega el producto a la ObservableCollection
                    Productos.Add(producto);
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que pueda ocurrir durante la lectura o deserialización del archivo
                    Console.WriteLine($"Error al leer/deserializar archivo: {ex.Message}");
                }
            }
        }
    }
}
