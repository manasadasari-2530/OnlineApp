namespace OnlineApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

	}

    private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {
        
    }

    

    private  async void MenuFlyoutItem_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OnlineApp.Pages.Caterory2());
    }

    private async void MenuFlyoutItem_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OnlineApp.Pages.Category3());
    }

    private void MenuFlyoutItem_Clicked_4(object sender, EventArgs e)
    {

    }

    private void MenuFlyoutItem_Clicked_5(object sender, EventArgs e)
    {

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OnlineApp.Pages.Category1());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new OnlineApp.Pages.Caterory2());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OnlineApp.Pages.Category3());
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_5(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_6(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_7(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_8(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_9(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_10(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_11(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_12(object sender, EventArgs e)
    {

    }

    private async void MenuFlyoutItem_Clicked_6(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OnlineApp.Pages.Category1());
    }
}