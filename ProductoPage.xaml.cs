namespace MAUI_Aplicacion;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using MAUI_Aplicacion.Models;
using System.Collections.ObjectModel;

public partial class ProductoPage : ContentPage
{
    private ObservableCollection<Producto> Productos;

    public ProductoPage()
    {
        InitializeComponent();
        Productos = new ObservableCollection<Producto>(Utils.Utils.ListaProducto);
        listaProductos.ItemsSource = Productos;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        // Actualiza la lista de productos cada vez que la página aparece
        Productos.Clear();
        foreach (var producto in Utils.Utils.ListaProducto)
        {
            Productos.Add(producto);
        }
    }
    private async void OnClickNuevoProducto(object sender, EventArgs e)
    {
        try
        {
            /*var toast = Toast.Make("On Click Boton Nuevo Producto", ToastDuration.Short, 14);
            await toast.Show();*/
            await Navigation.PushModalAsync(new NuevoProductoPage());
            //await Shell.Current.GoToAsync(nameof(MAUI_Aplicacion.NuevoProductoPage));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en OnClickNuevoProducto: {ex.Message}");
        }

    }

    private async void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
    {
        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushModalAsync(new DetalleProductoPage()
        {
            BindingContext = producto,
        }) ;

    }
}
