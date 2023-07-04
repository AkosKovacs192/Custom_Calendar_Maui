using Custom_Calendar_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Calendar_Library
{
    public class Day : IDay
    {
        public Day(DateTime dateTime)
        {
            DaySetup(dateTime);
        }
        public Day(DateOnly dateOnly)
        {
            DaySetup(new DateTime(dateOnly.Year,dateOnly.Month,dateOnly.Day));
        }
        private void DaySetup(DateTime dateTime)
        {
            this.DateTime = dateTime;
            this.DateOnly = new DateOnly(dateTime.Year,dateTime.Month,dateTime.Day);
            this.DayOfTheWeek = dateTime.DayOfWeek.ToString("d");
            this.IndexDayOfTheWeek = (int)dateTime.DayOfWeek;
        }

        private bool Selected {  get; set; }
        private DateTime DateTime { get; set; }
        private DateOnly DateOnly { get; set; }
        private string DayOfTheWeek { get; set; }
        private int IndexDayOfTheWeek { get; set; }
        private bool Active { get; set; }
   
        public void Select() { Selected = true; }
        public void DeSelect() { Selected = false; }
        public bool IsSelected() { return Selected; }
        public DateTime GetDateTime() { return DateTime; }
        public DateOnly GetDateOnly() { return DateOnly; }       
        public string GetDayOfTheWeek() { return DayOfTheWeek; }  
        public int GetIndexOfTheWeek() { return IndexDayOfTheWeek; }
        public bool IsActive() { return Active;  }
        public void Activate() { Active = true; }
        public void Deactivate() { Active = false; }
    }
}
