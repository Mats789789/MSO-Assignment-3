
using System.Runtime.CompilerServices;

namespace MSO3
{
    internal static class ExampleElements
    {
        //Example programs
        public const string basicProgram = 
            "Move 1\nTurn right\nMove 1\nTurn right\nMove 1\nTurn right\nMove 1";

        //Example grids
        public static readonly Tile[,] threeBythree = GridBuilder.BuildGrid(["ooo", "ooo", "ooo"]);
        public static readonly Tile[,] fiveByfive = GridBuilder.BuildGrid
            (["++ooo", "+oooo", "ooooo", "oooo+", "ooo++"]);
    }
}
