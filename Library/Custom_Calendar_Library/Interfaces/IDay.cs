using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Calendar_Library.Interfaces
{
    public interface IDay
    {

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
