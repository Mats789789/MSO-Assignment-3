
using System.Runtime.CompilerServices;

namespace MSO3
{
    internal static class ExampleElements
    {
        //Example programs
        public const string basicProgram =
            "Move 1\r\nTurn right\r\nMove 1\r\nTurn right\r\nMove 1\r\nTurn right\r\nMove 1\r\nTurn right";
        public const string advancedProgram =
            "Repeat 4 times\r\n    Move 1\r\n    Turn right";
        public const string expertProgram =
            "";

        //Example grids
        public static readonly Tile[,] threeBythree = GridBuilder.BuildGrid(["ooo", "ooo", "ooo"]);
        public static readonly Tile[,] fiveByfive = GridBuilder.BuildGrid
            (["ooo++", "+oooo", "ooooo", "oooo+", "ooo++"]);
    }
}
