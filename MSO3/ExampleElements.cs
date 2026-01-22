
using System.Runtime.CompilerServices;

namespace MSO3
{
    public static class ExampleElements
    {
        //Example programs
        public const string basicProgram =
            "Move 1\r\nTurn right\r\nMove 1\r\nTurn right\r\nMove 1\r\nTurn right\r\nMove 1\r\nTurn right";
        public const string advancedProgram =
            "Repeat 4 times\r\n    Move 1\r\n    Turn right";
        public const string expertProgram =
            "Move 1\r\nTurn right\r\nMove 5\r\nRepeat 3\r\n    Turn left\r\nMove 1\r\nTurn right\r\nMove 3\r\nRepeat 5\r\n    Turn right\r\n    Move 2\r\nTurn right\r\nMove 5\r\nTurn left\r\nMove 3";

        //Example grids
        public static readonly Tile[,] threeBythree = GridBuilder.BuildGrid(["ooo", "ooo", "ooo"]);

        public static readonly Tile[,] fiveByfive = GridBuilder.BuildGrid
            (["ooo++", "+oooo", "ooooo", "oooo+", "oxo++"]);

        public static readonly Tile[,] tenByTenEmpty = GridBuilder.BuildGrid
            (["oooooooooo", "oooooooooo", "oooooooooo", "oooooooooo", "oooooooooo", 
            "oooooooooo", "oooooooooo", "oooooooooo", "oooooooooo", "oooooooooo",]);

        public static readonly Tile[,] tenByTen = GridBuilder.BuildGrid
            (["ooooo+++++", "ooooooo+++", "+++++oooo+", "++++oooooo", "++oooooooo",
            "+ooo++oooo", "oooo++++oo", "ooooo+++++", "+ooooo++++", "+++ooox+++",]);
    }
}
