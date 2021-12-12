using System.Numerics;
using MarsRover.Concrete;
using MarsRover.Enums;
using Xunit;

namespace MarsRoverTest
{
    public class MarsRoverTest
    {
        [Theory]
        [InlineData(1, 2, Direction.NORTH, "LMLMLMLMM", "1 3 NORTH")]
        [InlineData(3, 3, Direction.EAST, "MMRMMRMRRM", "5 1 EAST")]
        public void RoverRun(float x, float y, Direction direction, string commands, string expected)
        {
            Rover rover = new(new Vector2(x, y), direction, commands);
            string output = rover.Start();
            Assert.Equal(expected, output);
        }
    }
}