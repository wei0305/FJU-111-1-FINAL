namespace first;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        NavigationPage.SetBackButtonTitle(this, "回登入頁面");
        buttonLogin.Clicked += ButtonLogin_Clicked;
    }
    private async void ButtonLogin_Clicked(object sender, EventArgs e)
    {
        // 回登入頁面
        var NextPage = new HomePage();
        

        await Navigation.PushAsync(NextPage);
    }
}
