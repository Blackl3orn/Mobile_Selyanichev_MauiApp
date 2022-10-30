namespace Mobile_Selyanichev_MauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void ButtonClicked(object sender, EventArgs e)
	{
		// передавать параметры можно через конструктор страницы
        Navigation.PushModalAsync(new Rooms());
    }

}

