namespace Custom_Calendar_Sample
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
            
        }

       
    }
}