using System.Windows.Forms;
using MSO3;

namespace TestEnvironment
{
    public class SystemTests
    {
        [Fact]
        public void Program_CharacterReachesEndState()
        {
            // Arrange
            var character = new Character();
            var program = new Program(character);
            var inputReader = new InputReader(program);
            var commandLines = ExampleElements.basicProgram;
            var gridLines = new List<string> { "ooo", "ooo", "ooo" };
            var panel = new Panel();

            // Act
            program.AttachUI(new Form1(program));

            var grid = GridBuilder.BuildGrid(gridLines);
            program.LoadGrid(grid, panel);

            var commands = inputReader.GetCommands(commandLines);
            program.RunProgram(new List<ICommand>(), false);

            // Assert
            Assert.Equal(new Point(0,0), character.Position);
        }
    }
}
