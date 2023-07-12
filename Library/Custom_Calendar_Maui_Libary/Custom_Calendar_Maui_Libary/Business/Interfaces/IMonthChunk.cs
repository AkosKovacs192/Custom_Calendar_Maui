using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Calendar_Maui_Libary.Business.Interfaces
{
    public interface IMonthChunk
    {
        public DateTime DateTime { get; }
        public DateOnly DateOnly { get; }
        public List<IDay> GetAllDays();
        public List<IDay> GetSelectedDays();
        public List<IDay> GetActiveDays();
        public List<IDay[]> GetWeeks();
    }
}
