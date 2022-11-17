using CommunityToolkit.Mvvm.ComponentModel;
using Mobile_Selyanichev_MauiApp.Models;
using Mobile_Selyanichev_MauiApp.Services;
using System.Collections.ObjectModel;

namespace Mobile_Selyanichev_MauiApp.ViewModels
{
    public partial class SolveProblemViewModel : ObservableObject
    {
        int room;

        [ObservableProperty]
        INavigation navigation;

        [ObservableProperty]
        ObservableCollection<Office> offices = new ObservableCollection<Office>();

        [ObservableProperty]
        Office  off = new Office { id="232"}; // не спрашивайте

        public SolveProblemViewModel(int room)
        {
            this.room = room;
            //problems = new Problem();
            Update();
        }

        async Task Update()
        {
            var problems = await GetProblemService.GetProblem(room); // НЕ СПРАШИВАЙТЕ 

            offices.Add(problems.office);
      

           
            //foreach (Problem problem in problems)
            //{
            //    this.problems.Add(problem);
            //}
        }
        //public async Task GetshitAsync()
        //{
        //    var govno = await GetProblemService.GetProblem(room);

        //    foreach (var govn in govno)
        //        problems.Add(govn);
        //}
        

        //[RelayCommand]
        //public async void SolveProblem()
        //{

        //    //удалятс
            
        //}
    }
}
