namespace Mobile_Selyanichev_MauiApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

	}

    private void ButtonClicked(object sender, EventArgs e)
	{
        Button btn = (Button)sender;
        // передавать параметры можно через конструктор страницы
        Navigation.PushModalAsync(new Rooms(btn.Text));
    }


}

