using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Selyanichev_MauiApp.Models
{
        // возвращает все завершенные проблемы
        public class Rootobject
        {
            public string ok { get; set; }
            public Office office { get; set; }
        }

        public class Office
        {
            public string id { get; set; }
            public string office { get; set; }
            public string numberPc { get; set; }
            public string problem { get; set; }
            public string status { get; set; }
            public string date { get; set; }
            public string time { get; set; }
        }

        //возвращает проблемы для данной аудитории (выводит только незавершенные проблемы)

}
