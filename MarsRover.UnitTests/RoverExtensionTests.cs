

using MarsRover;
using System.Collections.Generic;
using Xunit;

namespace MarsRover.UnitTests
{
    public class RoverExtensionTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void TryToExecuteSequenceOfCommandsTests(Rover input, string commands, Rover expected)
        {
            var actual = input.TryToExecuteSequenceOfCommands(commands);
            Assert.Equal(expected.CurrentState.Orientation, actual.CurrentState.Orientation);
            Assert.Equal(expected.CurrentState.Position.X, actual.CurrentState.Position.X);
            Assert.Equal(expected.CurrentState.Position.Y, actual.CurrentState.Position.Y);

            // Assert.Equals(expected.CurrentState , input.TryToExecuteSequenceOfCommands(commands).CurrentState);
        }
            



        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new Rover(), "MMRML", new Rover(new State(new Position(0, 2), Orientation.E)) };
            yield return new object[] { new Rover(), "MMMMMMMMMMMM", new Rover(new State(new Position(0, 10), Orientation.N)) };
            yield return new object[] { new Rover(), "MMMMMRMMMMMMMMMM", new Rover(new State(new Position(4, 5), Orientation.E)) };
            yield return new object[] { new Rover(), "RR", new Rover(new State(new Position(0, 0), Orientation.S)) };
            yield return new object[] { new Rover(), "LRL", new Rover(new State(new Position(0, 0), Orientation.W)) };
            yield return new object[] { new Rover(), "L", new Rover(new State(new Position(0, 0), Orientation.W)) };
            yield return new object[] { new Rover(), "R", new Rover(new State(new Position(0, 0), Orientation.E)) };
            yield return new object[] { new Rover(), "M", new Rover(new State(new Position(0, 1), Orientation.N)) };

        }
    }
}
