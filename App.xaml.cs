namespace MAUI_Aplicacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NuevoProductoPage();
        }
    }
}