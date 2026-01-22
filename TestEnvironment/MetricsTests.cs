using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSO3;

namespace TestEnvironment
{
    public class MetricsTests
    {
        [Fact]
        public void NumberOfCommands_ReturnsCorrectNumber()
        {
            //Arrange
            var commands = new List<string> { "Move 1", "Turn left", "Repeat 2 times" };
            
            //Act
            int result = Metrics.NumberOfCommands(commands);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void MaxNesting_ReturnsZeroForNoIndentation()
        {
            //Arrange
            var lines = new List<string> { "Move 1", "Turn left" };

            //Act
            int result = Metrics.MaxNesting(lines);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void MaxNesting_ReturnsCorrectMaxDepth()
        {
            //Arrange
            var lines = new List<string>
            {
                "Repeat 2 times",
                "    Move 1",
                "    Repeatuntil wall",
                "        Turn left"
            };

            //Act
            int result = Metrics.MaxNesting(lines);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void NumberOfRepeats_ReturnsCorrectNumber()
        {
            //Arrange
            var lines = new List<string>
            {
                "Repeat 2 times",
                "    Move 1",
                "RepeatUntil wall",
                "    Turn left"
            };

            //Act
            int result = Metrics.NumberOfRepeats(lines);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void NumberOfRepeats_OnlyCountsRepeats()
        {
            //Arrange
            var lines = new List<string>
            {
                "Move 1",
                "Turn left",
                "Repeat 2 times",
                "RepeatUntil wall"
            };

            //Act
            int result = Metrics.NumberOfRepeats(lines);

            //Assert
            Assert.Equal(2, result);
        }
    }
}
