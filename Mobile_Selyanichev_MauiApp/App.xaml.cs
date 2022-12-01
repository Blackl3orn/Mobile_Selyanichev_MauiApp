namespace Mobile_Selyanichev_MauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //MainPage = new NavigationPage(new MainPage()); никогда не помещать главную страницу в навигационный стак
         MainPage = new AppShell();
    }
}
