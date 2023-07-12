using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Calendar_Maui_Libary.Business.Interfaces
{
    public interface ICalendarYearMonth 
    {
        public int Month { get;  } 

        public int Year { get;  }

        public void NextYear() {}
        public void PrevYear() {}

        public void NextMonth() {}
        public void PrevMonth() {}
    }
}
