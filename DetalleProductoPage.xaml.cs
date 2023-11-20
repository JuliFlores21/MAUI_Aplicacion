using MAUI_Aplicacion.Models;

namespace MAUI_Aplicacion;

public partial class DetalleProductoPage : ContentPage
{
    private Producto _producto;
	public DetalleProductoPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _producto = BindingContext as Producto;
        if (_producto != null)
        {
            Nombre.Text = _producto.Nombre.ToString();
            Cantidad.Text = _producto.Cantidad.ToString();
            Descripcion.Text= _producto.Descripcion.ToString();
        }
    }

    private async void OnClickDetalleProducto(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void OnClickBorrarProducto(object sender, EventArgs e)
    {
        Utils.Utils.ListaProducto.Remove(_producto);
        await Navigation.PopModalAsync();
    }

    private async void OnClickEditarProducto(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NuevoProductoPage()
        {
            BindingContext = _producto,
        }); ;
    }
}