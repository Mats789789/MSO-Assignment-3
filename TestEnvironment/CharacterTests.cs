using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using MSO3;

namespace TestEnvironment
{
    public class CharacterTests
    {
        [Fact]
        public void Move_UpdatesPosition()
        {
            // Arrange
            var character = new Character();
            var startPosition = character.Position;

            // Act
            character.Move(1);

            // Assert
            Assert.NotEqual(startPosition, character.Position);
        }
        [Fact]
        public void Turn_ChangesDirection()
        {
            // Arrange
            var character = new Character();
            var startDirection = character.Direction;

            // Act
            character.Turn("right");

            // Assert
            Assert.NotEqual(startDirection, character.Direction);
        }
        [Fact]
        public void Reset_ResetsCharacterToInitialState()
        {
            // Arrange
            var character = new Character();
            var startDirection = character.Direction;
            var startposition = character.Position;

            // Act
            character.Turn("right");
            character.Move(5);
            character.Reset();

            // Assert
            Assert.Equal(startDirection, character.Direction);
            Assert.Equal(startposition, character.Position);
        }
    }
}
