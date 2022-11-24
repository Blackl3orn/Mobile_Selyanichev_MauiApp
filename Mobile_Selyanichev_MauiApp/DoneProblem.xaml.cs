using Mobile_Selyanichev_MauiApp.ViewModels;

namespace Mobile_Selyanichev_MauiApp;

public partial class DoneProblem : ContentPage
{
	public DoneProblem(DoneProblemViewModel vm)
    {
        vm.Navigation = Navigation;
        BindingContext = vm;
        InitializeComponent();
	}

    private void GoBackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}