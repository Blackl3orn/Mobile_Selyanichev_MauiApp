namespace Mobile_Selyanichev_MauiApp;

public partial class CreateProblem : ContentPage
{
	public CreateProblem()
	{
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

    private void PCID_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Problem_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void PCID_Completed(object sender, EventArgs e)
    {

    }

    private void Problem_Completed(object sender, EventArgs e)
    {

    }
}