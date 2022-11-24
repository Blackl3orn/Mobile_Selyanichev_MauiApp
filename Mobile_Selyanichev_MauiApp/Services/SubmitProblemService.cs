using Mobile_Selyanichev_MauiApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Selyanichev_MauiApp.Services
{
    public class SubmitProblemService
    {
        //добавить проблему
        //static string Url_add = "https://mobile.homlol.ru/addNewProblem";

        //возвращает проблемы для данной аудитории (выводит только незавершенные проблемы)
        //static string Uri_list = "https://mobile.homlol.ru/list";

        //возвращает все завершенные проблемы
        //static string Uri_list_all = "https://mobile.homlol.ru/listAll";

        static string Uri_submit = "https://mobile.homlol.ru/listUpdate";

        static HttpClient client;

        static SubmitProblemService()
        {
            client = new HttpClient() { BaseAddress = new Uri(Uri_submit) };
        }

        public static void GetProblem(int id)
        {
             client.GetStringAsync($"?id={id}");
          //  var problems = JsonConvert.DeserializeObject<Rootobject>(json);
          //  return problems;
        }
    }
}
