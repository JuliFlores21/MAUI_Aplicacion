namespace MAUI_Aplicacion;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;


public partial class ProductoPage : ContentPage
{
    public ProductoPage()
    {
        InitializeComponent();
        listaProductos.ItemsSource = Utils.Utils.ListaProducto;
    }
    private async void OnClickNuevoProducto(object sender, EventArgs e)
    {
        var toast = Toast.Make("On Click Boton Nuevo Producto", ToastDuration.Short, 14);
        await toast.Show();
    }
}
