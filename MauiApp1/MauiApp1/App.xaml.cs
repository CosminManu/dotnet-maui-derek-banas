namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage(new ContentPageDemo());
            navigationPage.BarBackground = Colors.Purple; 
            navigationPage.BarTextColor = Colors.White;

            MainPage = navigationPage;
        }
    }
}
