using Custom_Calendar_Maui_Libary.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Calendar_Maui_Libary.Business.Implementations
{
    public class CalendarYearMonth : ICalendarYearMonth
    {
        public int Month { get; set; } = 1;

        public int Year { get; set; } = 2000;


        public CalendarYearMonth(int year, int month)
        {
            if (month > 12 || month < 1)
                new Exception("Invalid month.");
            if (year < 1)
                new Exception("Invalid Year");

            this.Month = month;
            this.Year = year;
        }

        public void NextYear()
        {
            this.Year++;
        }
        public void PrevYear() {

            if(this.Year > 1)
                this.Year--;
        }

        public void NextMonth() {

            this.Month++;
            if (this.Month > 13)
                this.Month = 1;
        }
        public void PrevMonth() { 
        
            this.Month--;
            if(this.Month < 1 ) 
                this.Month = 13;        
        }


    }
}
