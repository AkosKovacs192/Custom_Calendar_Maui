using Custom_Calendar_Maui_Libary.Business.Implementations;
using Custom_Calendar_Maui_Libary.Business.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Custom_Calendar_Maui_Libary.Business.Views;

public partial class MonthView : ContentView, INotifyPropertyChanged
{

    public DateTime MonthToShow
    {
        get => _timeToShow;
        set
        {
            _timeToShow = value; OnPropertyChanged(nameof(MonthToShow));
            Render();
        }
    }
    private DateTime _timeToShow { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string name = "") =>
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    public List<IDay> Days
    {
        get => _days;
        set
        {
            _days = value; OnPropertyChanged(nameof(Days));
        }
    }
    private List<IDay> _days { get; set; }

    public IMonthChunk Month
    {
        get => _month;
        set
        {
            _month = value; OnPropertyChanged(nameof(Month));
        }
    }
    private IMonthChunk _month { get; set; }

    private void Render()
    {
        InitializeComponent();
        BindingContext = this;
        Month = new MonthChunk(MonthToShow);
        Days = Month.GetAllDays();
    }

     
}