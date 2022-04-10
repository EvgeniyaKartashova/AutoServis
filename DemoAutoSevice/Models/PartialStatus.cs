using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAutoSevice.Models
{
    partial class Status
    {
        public string StatusColor
        {
            get
            {
                if (Statusame == "Выполнено")
                { return "Green"; }
                if (Statusame == "Запланировано")
                { return "Bluee"; }
                if (Statusame == "Принята к исполнению")
                { return "Orange"; }
                return "Black";
            }
        }
    }
}
