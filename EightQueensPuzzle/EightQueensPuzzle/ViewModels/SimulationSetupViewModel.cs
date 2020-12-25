using EightQueensPuzzle.Views;
using Xamarin.Forms;

namespace EightQueensPuzzle.ViewModels
{
    public class SimulationSetupViewModel
    {
        public Command NavigateToSimulation { get; set; }

        public SimulationSetupViewModel()
        {
            NavigateToSimulation = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new SimulationPage
                {
                    BindingContext = new SimulationViewModel()
                });
            });
        }
    }
}
