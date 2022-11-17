using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Selyanichev_MauiApp.ViewModels
{
    public partial class RoomsViewModel : ObservableObject
    {
        [ObservableProperty]
        INavigation navigation;

       

        [RelayCommand]
        void GoBackButton_Clicked()
        {
            Navigation.PopModalAsync();
        }

        [RelayCommand]
        void RoomButton_Clicked()
        {
            // if нажата кнопка сообщить
            
            Navigation.PushModalAsync(new CreateProblem(new CreateProblemViewModel(selected)));
            // если вторая кнопка
            // Navigation.PushModalAsync(new SolveProblem());
        }
    }
}
