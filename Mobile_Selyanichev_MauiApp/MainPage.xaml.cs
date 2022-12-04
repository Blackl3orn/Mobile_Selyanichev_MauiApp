using Mobile_Selyanichev_MauiApp.ViewModels;

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
        Navigation.PushModalAsync(new Rooms(btn.Text));
    }


}

