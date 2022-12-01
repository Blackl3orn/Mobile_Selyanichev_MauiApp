using Mobile_Selyanichev_MauiApp.ViewModels;

namespace Mobile_Selyanichev_MauiApp;

public partial class Rooms : ContentPage
{
    bool navigator; // 0 - �������� 1 - ���������

    public Rooms(string text)
    {
       InitializeComponent();

        if (text == "��������")
        {
            navigator = false;
            this.DoneButton.IsVisible = false;
            this.Image1.Source = "teacher_background.png";

        }
        if (text == "���������")
        {
            navigator = true;
            this.DoneButton.IsVisible = true;
            this.Image1.Source = "tech_background.png";
        }
    }

    private void GoBackButton_Clicked(object sender, EventArgs e)
	{
        Navigation.PopModalAsync();
    }

	private void RoomButton_Clicked(object sender, EventArgs e)
	{
        Button btn = (Button)sender;
        // if ������ ������ ��������
        if (!navigator)
        Navigation.PushModalAsync(new CreateProblem(new CreateProblemViewModel(btn.Text)));
        // ���� ������ ������
        if (navigator)
        Navigation.PushModalAsync(new SolveProblem(new SolveProblemViewModel(btn.Text))); //218a
    }

    private void DoneButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new DoneProblem(new DoneProblemViewModel()));
    }
}