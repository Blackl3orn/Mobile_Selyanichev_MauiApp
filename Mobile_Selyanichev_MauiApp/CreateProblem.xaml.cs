using Mobile_Selyanichev_MauiApp.ViewModels;

namespace Mobile_Selyanichev_MauiApp;

public partial class CreateProblem : ContentPage
{
	public CreateProblem(CreateProblemViewModel vm)
	{
        vm.Navigation = Navigation;
        BindingContext = vm;
        InitializeComponent();
    }

    private void GoBackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private void SubmitButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

}