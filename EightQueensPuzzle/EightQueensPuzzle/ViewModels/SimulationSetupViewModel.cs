using System.Collections.Generic;
using EightQueensPuzzle.Models;
using EightQueensPuzzle.Views;
using Xamarin.Forms;

namespace EightQueensPuzzle.ViewModels
{
    public class SimulationSetupViewModel
    {
        public IReadOnlyList<Algorithm> Algorithms
        {
            get => Algorithm.GetAll();
        }

        public IReadOnlyList<ChessboardSize> Sizes
        {
            get => ChessboardSize.GetAll();
        }

        public Algorithm SelectedAlgorithm { get; set; }

        public ChessboardSize SelectedSize { get; set; }

        public Command NavigateToSimulation { get; set; }

        public SimulationSetupViewModel()
        {
            NavigateToSimulation = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new SimulationPage
                {
                    BindingContext = new SimulationViewModel
                    {
                        Algorithm = SelectedAlgorithm,
                        Size = SelectedSize
                    }
                });
            });
        }
    }
}
