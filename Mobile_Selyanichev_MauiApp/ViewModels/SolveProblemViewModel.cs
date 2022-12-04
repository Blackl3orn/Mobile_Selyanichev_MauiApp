﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mobile_Selyanichev_MauiApp.Models;
using Mobile_Selyanichev_MauiApp.Services;
using System.Collections.ObjectModel;

namespace Mobile_Selyanichev_MauiApp.ViewModels
{
    public partial class SolveProblemViewModel : ObservableObject
    {
        [ObservableProperty]
        string room;

        [ObservableProperty]
        INavigation navigation;

        public ObservableCollection<Office> Offices { get; set; }

        public SolveProblemViewModel(string room)
        {
            Offices = new();
            this.room = room;
            Update();
        }

        async Task Update()
        {
            Offices.Clear();
            Thread.Sleep(100);
            var problems = await GetProblemService.GetProblem(room);
            foreach(var something in problems.office)
            {
                Offices.Add(something);
            }
           
        }

        [RelayCommand]
        public void SubmitProblem(string id)
        {
            SubmitProblemService.GetProblem(int.Parse(id));
            Update();
        }
    }
}
