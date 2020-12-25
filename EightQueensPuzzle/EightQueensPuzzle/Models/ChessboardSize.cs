using System;
using System.Collections.Generic;
using System.Text;

namespace EightQueensPuzzle.Models
{
    public class ChessboardSize
    {
        public int Size { get; set; }

        public string Name
        {
            get => $"{Size}x{Size}";
        }

        public static IReadOnlyList<ChessboardSize> GetAll()
        {
            return new[]
            {
                new ChessboardSize {Size = 4},
                new ChessboardSize {Size = 5},
                new ChessboardSize {Size = 6},
                new ChessboardSize {Size = 7},
                new ChessboardSize {Size = 8},
                new ChessboardSize {Size = 9},
                new ChessboardSize {Size = 10},
                new ChessboardSize {Size = 11}
            };
        }
    }
}
