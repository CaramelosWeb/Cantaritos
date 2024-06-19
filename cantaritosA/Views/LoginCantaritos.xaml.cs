namespace cantaritosA.Views;

public partial class LoginCantaritos : ContentPage
{
    public LoginCantaritos()
	{
		InitializeComponent();
	}

    private async void Clicked(object sender, EventArgs e)
    {
        SemanticScreenReader.Announce(Login.Text);

        await Navigation.PushModalAsync(new Views.MenuCantaritos());
    }
    private async void ImageButton_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Views.RegistroCantaritos());
    }
}