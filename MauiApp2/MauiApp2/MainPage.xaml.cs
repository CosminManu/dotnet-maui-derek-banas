namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void StackLayoutBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackDemo());
        }
    }

}
