using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Forward : Command
    {
        public override State Execute(State state)
        {
            var newPosition = new Position(state.Position.X, state.Position.Y);
            switch (state.Orientation)
            {
                case Orientation.N:
                    newPosition.Y++;
                    break;

                case Orientation.S:
                    newPosition.Y--; ;
                    break;
                case Orientation.E:
                    newPosition.X++;
                    break;
                case Orientation.W:
                    newPosition.X--;
                    break;
            }
            return new State(newPosition, state.Orientation);
        }
    }
}

