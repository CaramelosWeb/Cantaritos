using cantaritosA.Models;

namespace cantaritosA.Views;

public partial class MenuCantaritos : ContentPage
{
    public List<Store> Stores { get; set; }
    public MenuCantaritos()

    {
        InitializeComponent();
        LoadData();
        BindingContext = this;
    }
    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Views.LoginCantaritos());
    }

    private async void Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Views.PedidoCantaritos());
    }
    private void LoadData()
    {
        Stores = new List<Store>
        {
            new Store
            {
                Id = 1,
                header = "original.jpg",
                producto = "Original",
                costo = 85,
                puntuacion = 4.5
            },

            new Store
            {
                Id = 2,
                header = "belico.jpg",
                producto = "Belico",
                costo = 120,
                puntuacion = 4.6
            },

            new Store
            {
                Id = 3,
                header = "tumbado.jpg",
                producto = "Tumbado",
                costo = 145,
                puntuacion = 4.8
            },

            new Store
            {
                Id = 4,
                header = "loco.jpg",
                producto = "Loco",
                costo = 160,
                puntuacion = 4.9
            },
        };

    }

    private async void AgregarAlCarrito_Clicked(object sender, EventArgs e)
    {
        // Verificar si el sender es un botón
        if (sender is Button boton)
        {
            // Obtener el contexto de enlace (BindingContext) del botón
            var contexto = boton.BindingContext;

            // Verificar si el contexto de enlace es del tipo Store
            if (contexto is Store productoSeleccionado)
            {
                // Navegar a la página de carrito y pasar el producto seleccionado como parámetro
                await Navigation.PushModalAsync(new Views.CarritoCantaritos(productoSeleccionado));
            }
            else
            {
                // Mostrar una alerta si el contexto de enlace no es del tipo Store
                await DisplayAlert("Error", "El producto seleccionado no es válido.", "OK");
            }
        }
        else
        {
            // Mostrar una alerta si el sender no es un botón
            await DisplayAlert("Error", "El elemento que generó el evento no es un botón.", "OK");
        }
    }

}