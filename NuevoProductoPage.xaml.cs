using MAUI_Aplicacion.Models;
using MAUI_Aplicacion.Utils;

namespace MAUI_Aplicacion;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
		
    }
	private void OnAgregarProductoClicked(object sender, EventArgs e)
	{
        string nombre = Nombre.Text;
        int cantidad = Convert.ToInt32(Cantidad.Text);
        string descripcion = Descripcion.Text;
        int id = Utils.Utils.ListaProducto.Count + 1;
		Utils.Utils.ListaProducto.Add(new Producto
        {
            Nombre = nombre,
            Cantidad = cantidad,
            Descripcion = descripcion,
            IdProducto = id
        });
    }
}