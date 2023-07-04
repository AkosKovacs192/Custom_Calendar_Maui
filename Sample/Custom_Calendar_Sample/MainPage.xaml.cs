namespace Custom_Calendar_Sample
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
            var a = new Custom_Calendar_Library.Calendar();
            var b = a.Monts;
        }

       
    }
}