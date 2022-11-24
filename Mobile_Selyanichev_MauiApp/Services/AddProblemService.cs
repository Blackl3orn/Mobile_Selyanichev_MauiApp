
using Mobile_Selyanichev_MauiApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Selyanichev_MauiApp.Services
{
    public class AddProblemService
    {
        //добавить проблему
        static string Url_add = "https://mobile.homlol.ru/addNewProblem";

        //возвращает проблемы для данной аудитории (выводит только незавершенные проблемы)
        //static string Uri_list = "https://mobile.homlol.ru/list";

        //возвращает все завершенные проблемы
        //static string Uri_list_all = "https://mobile.homlol.ru/listAll";

        static HttpClient client;

        static AddProblemService() {
            client = new HttpClient() { BaseAddress = new Uri(Url_add) };
        }
       
        public static async Task<Responce> AddProblem(string room, string pcNum, string problemDescr)
        {
            var json = await client.GetStringAsync($"?office={room}&numberPc={pcNum}&problem={problemDescr}");
            var responce = JsonConvert.DeserializeObject<Responce>(json);
            return responce;
        }

        // если не создалось можно обработать if (responce == залупа) {} 
    }
}
