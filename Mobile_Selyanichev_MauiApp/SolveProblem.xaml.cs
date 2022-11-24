using Mobile_Selyanichev_MauiApp.ViewModels;

namespace Mobile_Selyanichev_MauiApp;

public partial class SolveProblem : ContentPage
{
	public SolveProblem(SolveProblemViewModel vm)
	{
        vm.Navigation = Navigation;
        BindingContext = vm;
        
        InitializeComponent();
       // govno.ItemsSource = vm.Offices;
	}

    private void GoBackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    


    /* в связанном viewmodel класс под хранение строк, привязать к CollectionView*/
  
    
}