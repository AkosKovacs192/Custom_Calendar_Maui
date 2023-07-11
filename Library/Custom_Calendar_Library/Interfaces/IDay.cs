using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Calendar_Library.Interfaces
{
    public interface IDay
    {
        public  DateTime DateTime {  get;  }
        public  DateOnly DateOnly {  get;  }

        public bool IsToday { get; }
        public int Date { get; }
        public bool Selected { get; }
        public string DayOfTheWeek { get;  }
        public int IndexDayOfTheWeek { get;  }
        public bool Active { get;  }

        public void Select();
        public void DeSelect();
        public bool IsSelected();
        DateTime GetDateTime();
        DateOnly GetDateOnly();
        /// <summary>
        /// Monday
        /// Tuesday
        /// ...
        /// </summary>
        /// <returns></returns>
        string GetDayOfTheWeek();
        /// <summary>
        /// 0 == Monday
        /// 1 == Tuesday
        /// ...
        /// </summary>
        /// <returns></returns>
        int GetIndexOfTheWeek();        
        bool IsActive();
        void Activate();
        void Deactivate();

    }
}
