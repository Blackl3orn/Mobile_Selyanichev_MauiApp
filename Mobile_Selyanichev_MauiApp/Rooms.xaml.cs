using Mobile_Selyanichev_MauiApp.ViewModels;

namespace Mobile_Selyanichev_MauiApp;

public partial class Rooms : ContentPage
{
    bool navigator; // 0 - сообщить 1 - проверить

    public Rooms(string text)
    {
       InitializeComponent();

        if (text == "Сообщить")
        {
            navigator = false;
            this.DoneButton.IsVisible = false;
        }
        if (text == "Проверить")
        {
            navigator = true;
            this.DoneButton.IsVisible = true;
        }
    }

    private void GoBackButton_Clicked(object sender, EventArgs e)
	{
        Navigation.PopModalAsync();
    }

	private void RoomButton_Clicked(object sender, EventArgs e)
	{
        Button btn = (Button)sender;
        // if нажата кнопка сообщить
        if (!navigator)
        Navigation.PushModalAsync(new CreateProblem(new CreateProblemViewModel(btn.Text)));
        // если вторая кнопка
        if (navigator)
        Navigation.PushModalAsync(new SolveProblem(new SolveProblemViewModel(btn.Text))); //218a
    }

    private void DoneButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new DoneProblem(new DoneProblemViewModel()));
    }
}