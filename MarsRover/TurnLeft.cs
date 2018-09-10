using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class TurnLeft : Command
    {
        public override State Execute(State state)
        {
            var newOrientation = state.Orientation;
            switch (state.Orientation)
            {
                case Orientation.N:
                    newOrientation = Orientation.W;
                    break;
                case Orientation.W:
                    newOrientation = Orientation.S;
                    break;
                case Orientation.S:
                    newOrientation = Orientation.E;
                    break;
                case Orientation.E:
                    newOrientation = Orientation.N;
                    break;
                default:
                    break;
            };

            return new State(state.Position, newOrientation);
        }
    }
}
