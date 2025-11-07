
using System.Runtime.CompilerServices;

namespace MSO3
{
    internal static class ExampleElements
    {
        //Example programs
        public const string basicProgram = 
            "Move 1\nTurn right\nMove 1\nTurn right\nMove 1\nTurn right\nMove 1";

        //Example grids
        public static readonly bool[,] threeBythree = GridBuilder.BuildGrid(["ooo", "ooo", "ooo"]);
        public static readonly bool[,] fiveByfive = GridBuilder.BuildGrid
            (["xxooo", "xoooo", "ooooo", "oooox", "oooxx"]);
    }
}
