using cantaritosA.Models;
using Microsoft.Maui.Controls;

namespace cantaritosA.Views;

public partial class CarritoCantaritos : ContentPage
{
    private Store producto;

    public CarritoCantaritos(Store producto)
    {
        InitializeComponent();
        this.producto = producto;
        BindingContext = this.producto;
    }
    private async void Clicked1(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Views.MenuCantaritos());
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Views.PedidoCantaritos());
    }
}