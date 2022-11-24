namespace first;

public partial class HomePage : ContentPage
{


    public HomePage()
    {
        InitializeComponent();

        NavigationPage.SetBackButtonTitle(this, "回登入頁面");
        buttonEnter.Clicked += ButtonEnter_Clicked;


    }

    private async void ButtonEnter_Clicked(object sender, EventArgs e)
    {
        // 切換到選擇畫面
        var NextPage = new Start();

        await Navigation.PushAsync(NextPage);
    }


}