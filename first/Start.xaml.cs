namespace first;

public partial class Start : ContentPage
{
    public Start()
    {
        InitializeComponent();

        NavigationPage.SetBackButtonTitle(this, "返回");
        buttonScan.Clicked += ButtonScan_Clicked;
    }
    private async void ButtonScan_Clicked(object sender, EventArgs e)
    {
        // 返回
        var NextPage = new ScanPage();

        await Navigation.PushAsync(NextPage);
    }
}