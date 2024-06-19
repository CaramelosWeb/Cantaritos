using cantaritosA.Views;

namespace cantaritosA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /* MainPage = new LoginCantaritos(); */
            /* MainPage = new MenuCantaritos(); */
            /* MainPage = new PedidoCantaritos(); */
            /* MainPage = new RegistroCantaritos(); */
          
             MainPage = new NavigationPage(new LoginCantaritos()); 
        }
    }
}
