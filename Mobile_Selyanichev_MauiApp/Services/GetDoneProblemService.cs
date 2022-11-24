using Mobile_Selyanichev_MauiApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Selyanichev_MauiApp.Services
{
    public class GetDoneProblemService
    {
        //добавить проблему
        //static string Url_add = "https://mobile.homlol.ru/addNewProblem";

        //возвращает проблемы для данной аудитории (выводит только незавершенные проблемы)
        //static string Uri_list = "https://mobile.homlol.ru/list";

        //возвращает все завершенные проблемы
        static string Uri_list_all = "https://mobile.homlol.ru/listAll";

        static HttpClient client;

        static GetDoneProblemService()
        {
            client = new HttpClient() { BaseAddress = new Uri(Uri_list_all) };
        }

        public static async Task<Rootobject> GetDoneProblem()
        {
            var json = await client.GetStringAsync("");
            var problems = JsonConvert.DeserializeObject<Rootobject>(json);
            return problems;
        }
    }
}
