namespace OnlineApp;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private async void sfButton_Clicked(object sender, EventArgs e)
    {
       await Navigation.PushAsync(new OnlineApp.Pages.HomePage());
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new OnlineApp.MainPage());
    }
}