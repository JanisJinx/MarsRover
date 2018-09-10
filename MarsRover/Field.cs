using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public class Field
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public List<Position> ObstaclePoints = new List<Position> { new Position(5, 5), new Position(1,2) };

        public Field(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public bool IsThereObstacleForPosition(Position position) =>
             ObstaclePoints.Where(item => item.X == position.X && item.Y == position.Y).Any();

        public bool IsOutOfBoundaries(Position position) =>
            position.X > Width || position.Y > Length;
        
    }
}
