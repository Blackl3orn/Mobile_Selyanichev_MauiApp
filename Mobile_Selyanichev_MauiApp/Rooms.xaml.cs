namespace Mobile_Selyanichev_MauiApp;

public partial class Rooms : ContentPage
{
	public Rooms()
	{
		InitializeComponent();
	}

	private void GoBackButton_Clicked(object sender, EventArgs e)
	{
        Navigation.PopModalAsync();
    }

	private void RoomButton_Clicked(object sender, EventArgs e)
	{
		// if ������ ������ ��������
       // Navigation.PushModalAsync(new CreateProblem());
        // ���� ������ ������
        Navigation.PushModalAsync(new SolveProblem());
    }
}