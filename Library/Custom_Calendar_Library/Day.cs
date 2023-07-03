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

        public void Select() { }
        public void DeSelect() { }
        public bool IsSelected() { return false; }
        public DateTime GetDateTime() { return new DateTime(); }
        public DateOnly GetDateOnly() { return new DateOnly(); }
       
        public string GetDayOfTheWeek() { return string.Empty; }
  
        public int GetIndexOfTheWeek() { return 0; }
        public bool IsActive() { return false;  }
        public void Activate() { }
        public void Deactivate() { }
    }
}
