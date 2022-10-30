namespace Mobile_Selyanichev_MauiApp;

public partial class SolveProblem : ContentPage
{
	public SolveProblem()
	{
		InitializeComponent();
	}

    private void GoBackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private void SubmitButton_Clicked(object sender, EventArgs e)
    {
        // удалить элемент из списка проблем
    }


    /* в связанном viewmodel класс под хранение строк, привязать к CollectionView*/
  
    
}