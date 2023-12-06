namespace OnlineApp
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

      

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new OnlineApp.RegisterPage());
        }

        private async void sfButton_Clicked(object sender, EventArgs e)
        {
            var Lpage = (OnlineApp.DataModel)dataForm.DataObject;
            if (Lpage.username == "Team" &&
                Lpage.password == "1210")
            {
               await Navigation.PushAsync(new OnlineApp.Pages.HomePage());
            }
            else
            {
               await DisplayAlert("Error", "Invalid username and password", "OK");
            }
        }
    }

}
