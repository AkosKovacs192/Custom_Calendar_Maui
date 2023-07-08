 
using Custom_Calendar_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Calendar_Sample
{
    public class MainPageViewModel 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        public List<IDay[]> Days
        {
            get => _days;
            set
            {
                _days = value; OnPropertyChanged(nameof(Days));
            }
        }
        private List<IDay[]> _days { get; set; }
        public MainPageViewModel()
        {
            Days = new Custom_Calendar_Library.Calendar().Monts.FirstOrDefault().GetWeeks();
            
        }


    }
}
