using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Obstacle
    {
        public Position Begining { get; set; }
        public Position End { get; set; }
        public Line line
        {
            get
            {
                return Begining.X == End.X ? Line.Vertical : Line.Horizontal;
            }
        }

       
        public Obstacle (Position begining, Position end)
        {
            if (!(begining.X == end.X || begining.Y == end.Y))
                throw new ArgumentException();
            Begining = begining;
            End = end;
        }
    }

}
