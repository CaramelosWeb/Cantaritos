using MauiPopup;
using MauiPopup.Views;
using Microsoft.Maui.Controls;
using System;
using System.Diagnostics;

namespace cantaritosA.Views;

public partial class PedidoCantaritos : ContentPage
{
	public PedidoCantaritos()
	{
		InitializeComponent();
	}
    private async void Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Views.MenuCantaritos());
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Finaliza: Compra", "Efectivo. Original.. $120...", "Finalizar");
    }

}