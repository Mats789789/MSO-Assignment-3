using MSO3;

namespace TestEnvironment
{
    public class GridBuilderTests
    {
        [Fact]
        public void BuildGrid_CreatesCorrectGrid()
        {
            // Arrange
            var lines = new List<string> { "o+", "+o" };

            // Act
            var grid = GridBuilder.BuildGrid(lines);

            // Assert
            Assert.Equal(Tile.Open, grid[0, 0]);
            Assert.Equal(Tile.Blocked, grid[0, 1]);
            Assert.Equal(Tile.Blocked, grid[1, 0]);
            Assert.Equal(Tile.Open, grid[1, 1]);
        }

        [Fact]
        public void BuildGrid_ThrowsExceptionOnUnknownCharacter()
        {
            // Arrange
            var lines = new List<string> { "oz!" };

            // Act & Assert
            Assert.Throws<NotImplementedException>(() => GridBuilder.BuildGrid(lines));
        }
    }
}