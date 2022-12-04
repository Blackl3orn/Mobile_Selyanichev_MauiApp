
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mobile_Selyanichev_MauiApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Selyanichev_MauiApp.ViewModels
{
    public partial class CreateProblemViewModel : ObservableObject
    {

        [ObservableProperty]
        INavigation navigation; 

        [ObservableProperty]
        string pcNumEntrytext;

        [ObservableProperty]
        string problemEntrytext;

        [ObservableProperty]
        string room;

        public CreateProblemViewModel(string room)
        {
            this.room = room;
        }

        [RelayCommand]
        public async void AddProblem()
        {
            await AddProblemService.AddProblem(room, pcNumEntrytext, problemEntrytext);
        }

    }
}
