using CommunityToolkit.Mvvm.ComponentModel;
using Mobile_Selyanichev_MauiApp.Models;
using Mobile_Selyanichev_MauiApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Selyanichev_MauiApp.ViewModels
{
    public partial class DoneProblemViewModel : ObservableObject
    {
        [ObservableProperty]
        INavigation navigation;

        [ObservableProperty]
        ObservableCollection<Office> offices = new ObservableCollection<Office>();

        public DoneProblemViewModel()
        {
            Update();
        }

        async Task Update()
        {
            var problems = await GetDoneProblemService.GetDoneProblem();
            foreach (var something in problems.office)
            {
                offices.Add(something);
            }
        }
    }
}
