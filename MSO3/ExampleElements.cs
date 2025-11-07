
using System.Runtime.CompilerServices;

namespace MSO3
{
    internal static class ExampleElements
    {
        //Example programs
        public const string basicProgram =
            "Move 1\r\nTurn right\r\nMove 1\r\nTurn right\r\nMove 1\r\nTurn right\r\nMove 1";
        public const string advancedProgram =
            "Repeat 4 times\r\n    Move 1\r\n    Turn right";
        public const string expertProgram =
            "";

        //Example grids
        public static readonly bool[,] threeBythree = GridBuilder.BuildGrid(["ooo", "ooo", "ooo"]);
        public static readonly bool[,] fiveByfive = GridBuilder.BuildGrid
            (["oooxx", "oooox", "ooooo", "oooox", "oooxx"]);
    }
}
