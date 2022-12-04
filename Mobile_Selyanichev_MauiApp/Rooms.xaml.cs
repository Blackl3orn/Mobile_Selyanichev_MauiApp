using Mobile_Selyanichev_MauiApp.Services;
using Mobile_Selyanichev_MauiApp.ViewModels; 

namespace Mobile_Selyanichev_MauiApp;

public partial class Rooms : ContentPage
{
    bool navigator; // 0 - сообщить 1 - проверить

    TupleList<Button, string> buttons;

    public Rooms(string text)
    {
       InitializeComponent();

       buttons = new TupleList<Button  , string>  { { Room205mark,  "205"},
                                                    { Room213mark, "213" },
                                                    { Room214mark, "214" },
                                                    { Room215mark, "215" },
                                                    { Room216mark, "216" },
                                                    { Room217mark, "217" },
                                                    { Room218amark,"218a"},
                                                    { Room218mark, "218" },
                                                    { Room219mark, "219" },
                                                    { Room221mark, "221" },
                                                    { Room227mark, "227" },
                                                    { Room228mark, "228" },
                                                    { Room229mark, "229" },
                                                    { Room230mark, "230" } };

       MessagingCenter.Subscribe<Page>(this, "do", async (sender) => { foreach (var tuple in buttons)
                                                                       { 
                                                                           await GetNotifications(tuple.Item1, tuple.Item2); 
                                                                       } 
                                                                                                                              });

       if (text == "Сообщить")
       {
           navigator = false;
           this.DoneButton.IsVisible = false;
           this.Image1.Source = "teacher_background.png";

           foreach(var tuple in buttons)
           {
               tuple.Item1.IsVisible = false;
           }
       }

       if (text == "Проверить")
       {
           navigator = true;
           this.DoneButton.IsVisible = true;
           this.Image1.Source = "tech_background.png";
           this.Resources["xxx"] = GetResourceValue("PrimaryRed");
 
           foreach (var tuple in buttons)
           {
                GetNotifications(tuple.Item1, tuple.Item2);
           }
       }
    }

    private void GoBackButton_Clicked(object sender, EventArgs e)
	{
        Navigation.PopModalAsync();
    }

	private void RoomButton_Clicked(object sender, EventArgs e)
	{
        Button btn = (Button)sender;
        // if нажата кнопка сообщить
        if (!navigator)
        Navigation.PushModalAsync(new CreateProblem(new CreateProblemViewModel(btn.Text)));
        // если вторая кнопка
        if (navigator)
        Navigation.PushModalAsync(new SolveProblem(new SolveProblemViewModel(btn.Text)));  
    }

    private void DoneButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new DoneProblem(new DoneProblemViewModel()));
    }

    private static object GetResourceValue(string keyName)
    {
        // Search all dictionaries
        if (App.Current.Resources.TryGetValue(keyName, out var retVal)) { }
        return retVal;
    }

    private async Task GetNotifications(Button button, string room)
    {
        var problems = await GetProblemService.GetProblem(room);
        var tmp = problems.office.Length;
        if (tmp != 0)
            button.Text = tmp.ToString();
        else button.IsVisible = false;
    }

    public class TupleList<T1, T2> : List<Tuple<T1, T2>>
    {
        public void Add(T1 item, T2 item2)
        {
            Add(new Tuple<T1, T2>(item, item2));
        }
    }
}