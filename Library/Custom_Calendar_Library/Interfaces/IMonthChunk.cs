using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Calendar_Library.Interfaces
{
    public interface IMonthChunk
    {
        
        public List<IDay> GetAllDays();
        public List<IDay> GetSelectedDays();
        public List<IDay> GetActiveDays();

        public List<IDay[]> GetWeeks();
    }
}
