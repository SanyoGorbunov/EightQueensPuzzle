using EightQueensPuzzle.Models;

namespace EightQueensPuzzle.ViewModels
{
    public class SimulationViewModel
    {
        public Algorithm Algorithm { get; set; }

        public ChessboardSize Size { get; set; }
    }
}