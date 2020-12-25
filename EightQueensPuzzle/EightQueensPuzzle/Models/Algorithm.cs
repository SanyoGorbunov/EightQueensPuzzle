using System.Collections.Generic;

namespace EightQueensPuzzle.Models
{
    public class Algorithm
    {
        public string Name { get; set; }

        public AlgorithmType AlgorithmType { get; set; }

        public static IReadOnlyList<Algorithm> GetAll()
        {
            return new List<Algorithm>
            {
                new Algorithm {AlgorithmType = AlgorithmType.Dfs, Name = "Depth-First Search"},
                new Algorithm {AlgorithmType = AlgorithmType.Bfs, Name = "Breadth-First Search"}
            };
        }
    }

    public enum AlgorithmType
    {
        Dfs,
        Bfs
    }
}
