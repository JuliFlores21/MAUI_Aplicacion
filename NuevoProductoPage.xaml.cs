using MAUI_Aplicacion.Models;
using MAUI_Aplicacion.Utils;

namespace MAUI_Aplicacion;

public partial class NuevoProductoPage : ContentPage
{
    private Producto _producto;
	public NuevoProductoPage()
	{
		InitializeComponent();		
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _producto = BindingContext as Producto;
        if (_producto != null )
        {
            Nombre.Text = _producto.Nombre;
            Cantidad.Text = _producto.Cantidad.ToString();
            Descripcion.Text = _producto.Descripcion;
        }
    }
    private async void OnAgregarProductoClicked(object sender, EventArgs e)
	{
        if(_producto != null)
        {
            _producto.Nombre = Nombre.Text;
            _producto.Descripcion= Descripcion.Text;
            _producto.Cantidad = Convert.ToInt32(Cantidad.Text);
        }
        else { 
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
        await Navigation.PopModalAsync();
    }

    private async void OnCancelarClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}