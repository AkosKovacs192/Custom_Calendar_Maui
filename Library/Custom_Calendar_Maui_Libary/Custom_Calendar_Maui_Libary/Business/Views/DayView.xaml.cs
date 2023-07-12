using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Custom_Calendar_Maui_Libary.Business.Views;

public partial class DayView : ContentView {


    public DayView()
	{
		InitializeComponent();
		BindingContext= this;
	}
}