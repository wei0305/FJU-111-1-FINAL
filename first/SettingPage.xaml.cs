namespace first;

public partial class SettingPage : ContentPage
{
    public SettingPage()
    {
        InitializeComponent();

        NavigationPage.SetBackButtonTitle(this, "返回");
        buttonChangeAC.Clicked += ButtonChangeAC_Clicked;
        buttonChangePW.Clicked += ButtonChangePW_Clicked;
        buttonLogOut.Clicked += ButtonLogOut_Clicked;
    }

    private async void ButtonChangeAC_Clicked(object sender, EventArgs e)
    {
        // 返回
        var NextPage = new ChangeAccountPage();

        await Navigation.PushAsync(NextPage);
    }

    private async void ButtonChangePW_Clicked(object sender, EventArgs e)
    {
        // 返回
        var NextPage = new ChangePasswordPage();

        await Navigation.PushAsync(NextPage);
    }
    private async void ButtonLogOut_Clicked(object sender, EventArgs e)
    {
        // 返回
        var NextPage = new MainPage();

        await Navigation.PushAsync(NextPage);
    }

}
