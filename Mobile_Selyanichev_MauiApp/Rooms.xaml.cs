using Mobile_Selyanichev_MauiApp.ViewModels;

namespace Mobile_Selyanichev_MauiApp;

public partial class Rooms : ContentPage
{
    string text;

	public Rooms(
        string text
      //  RoomsViewModel vm
        )
	{
        this.text = text;
      //  vm.Navigation = Navigation;
      //  BindingContext = vm;
        InitializeComponent();
	}

    private void GoBackButton_Clicked(object sender, EventArgs e)
	{
        Navigation.PopModalAsync();
    }

	private void RoomButton_Clicked(object sender, EventArgs e)
	{
        Button btn = (Button)sender;
        // if ������ ������ ��������
        if (text == "��������")
        Navigation.PushModalAsync(new CreateProblem(new CreateProblemViewModel(int.Parse(btn.Text))));
        // ���� ������ ������
        if (text == "���������")
        Navigation.PushModalAsync(new SolveProblem(new SolveProblemViewModel(int.Parse(btn.Text))));
    }
}