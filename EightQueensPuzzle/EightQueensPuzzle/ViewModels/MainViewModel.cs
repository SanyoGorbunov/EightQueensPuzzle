using Xamarin.Forms;

namespace EightQueensPuzzle.ViewModels
{
    public class MainViewModel
    {
        public Command NavigateToSimulationSetup { get; set; }

        public Command NavigateToSolutions { get; set; }

        public Command NavigateToBenchmarks { get; set; }

        public MainViewModel()
        {
            NavigateToSimulationSetup = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views.SimulationSetupPage
                {
                    BindingContext = new SimulationSetupViewModel()
                });
            });    

            NavigateToSolutions = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views.SolutionsPage
                {
                    BindingContext = new SolutionsViewModel()
                });
            });

            NavigateToBenchmarks = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views.BenchmarksPage
                {
                    BindingContext = new BenchmarksViewModel()
                });
            });
        }
    }
}
