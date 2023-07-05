using Custom_Calendar_Library.Interfaces;

namespace Custom_Calendar_Library
{
    public class Calendar
    {

        public List<IMonthChunk> Monts { get; set; }

        public Calendar()
        {
            Monts = new List<IMonthChunk>();
            Monts.Add(new MonthChunk(DateTime.Now));
        }

    }
}