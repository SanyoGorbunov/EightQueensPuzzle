using EightQueensPuzzle.ViewModels;
using Xamarin.Forms;

namespace EightQueensPuzzle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainPage = new Views.MainPage();
            mainPage.BindingContext = new MainViewModel();
            MainPage = new NavigationPage(mainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
