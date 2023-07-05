using Custom_Calendar_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Calendar_Library
{
    public class MonthChunk : IMonthChunk
    {
        private List<IDay> Days { get; set; }

        public MonthChunk(DateTime dateTime) { 
            
            GenerateChunk(dateTime);
        }

        public MonthChunk(DateOnly dateOnly){
            
            GenerateChunk(new DateTime(dateOnly.Year, dateOnly.Month, dateOnly.Day));
        }

        private void GenerateChunk(DateTime dateTime) {

            Days = new List<IDay>();
            DateOnly date = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
            int days = DateTime.DaysInMonth(date.Year, date.Month);
            for (int day = 1; day <= days; day++)
            {
                IDay _day = new Day(new DateOnly(date.Year, date.Month, day));
                _day.Activate();
                Days.Add(_day);
            }

            DateTime prevousMonth = dateTime;
            while (Days.First().GetIndexOfTheWeek() != 1)
            {
                prevousMonth = prevousMonth.AddDays(-1);
                Days.Insert(0, new Day(new DateOnly(prevousMonth.Year, prevousMonth.Month, prevousMonth.Day)));
            }
            DateTime nextMonth = new DateTime(Days.Last().GetDateTime().Year, Days.Last().GetDateTime().Month, Days.Last().GetDateTime().Day);
            while (Days.Last().GetIndexOfTheWeek() != 0)
            {
                nextMonth = nextMonth.AddDays(1);
                Days.Add(new Day(new DateOnly(nextMonth.Year, nextMonth.Month, nextMonth.Day)));
            }
        }
        public List<IDay> GetAllDays() { return Days; }
        public List<IDay> GetSelectedDays() { return new List<IDay>(); }
        public List<IDay> GetActiveDays() { return new List<IDay>(); }

    }
}
