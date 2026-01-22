using MSO3;

namespace TestEnvironment
{
    public class InputReaderTests
    {
        [Fact]
        public void GetCommands_ParsesCorrectCommandTypes()
        {
            // Arrange
            var character = new Character();
            var program = new Program(character);
            var reader = new InputReader(program);
            string input = "Move 2\nTurn left";

            // Act
            var commands = reader.GetCommands(input);

            // Assert
            Assert.IsType<MoveCommand>(commands[0]);
            Assert.IsType<TurnCommand>(commands[1]);
        }
        [Fact]
        public void GetCommands_ParsesRepeatCommand()
        {
            // Arrange
            var character = new Character();
            var program = new Program(character);
            var reader = new InputReader(program);
            string input = "Repeat 2 times\n    Move 1\n    Turn right";

            // Act
            var commands = reader.GetCommands(input);

            // Assert
            Assert.IsType<RepeatCommand>(commands[0]);
        }
        [Fact]
        public void GetCommands_ParsesRepeatuntilCommand()
        {
            // Arrange
            var character = new Character();
            var program = new Program(character);
            var reader = new InputReader(program);
            string input = "RepeatUntil wall\n    Move 1\n    Turn right";

            // Act
            var commands = reader.GetCommands(input);

            // Assert
            Assert.IsType<RepeatUntilCommand>(commands[0]);
        }
        [Fact]
        public void GetCommands_ExecutesCommandBodyCommands()
        {
            // Arrange
            Character character = new Character();
            var program = new Program(character);
            Point startPosition = character.Position;

            var reader = new InputReader(program);
            string input = "Repeat 2 times\n    Move 1\n    Turn right";

            // Act
            var commands = reader.GetCommands(input);
            commands[0].Execute(character);

            // Assert
            Assert.NotEqual(startPosition, character.Position);
        }
    }
}
