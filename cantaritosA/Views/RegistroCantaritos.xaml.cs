namespace cantaritosA.Views;

public partial class RegistroCantaritos : ContentPage
{
	public RegistroCantaritos()
	{
		InitializeComponent();
	}
    private async void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Views.LoginCantaritos());
    }
}