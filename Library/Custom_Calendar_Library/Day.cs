using Custom_Calendar_Library.Interfaces;
using Microsoft.VisualBasic;
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
            this.DayOfTheWeek = dateTime.DayOfWeek.ToString();
            this.IndexDayOfTheWeek = (int)dateTime.DayOfWeek;
            this.Date = dateTime.Day;
            IsToday = dateTime.Day == DateTime.Now.Day && DateTime.Month == DateTime.Now.Month && DateTime.Year == DateTime.Now.Year;
            if(IsToday)
            {
               // this.IsToday = false;
            }
        }

        public bool IsToday { get; set; }
        public bool Selected {  get; set; }
        public DateTime DateTime { get; set; }
        public DateOnly DateOnly { get; set; }
        public int Date { get; set; }
        public string DayOfTheWeek { get; set; }
        public int IndexDayOfTheWeek { get; set; }
        public bool Active { get; set; }
   
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
