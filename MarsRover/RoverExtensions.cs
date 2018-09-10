using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public static class RoverExtensions
    {
        public static Rover TryToExecuteSequenceOfCommands(this Rover rover, string commands)
        {
            var listOfCommands = commands.ToCharArray().ToList();
            foreach (var item in listOfCommands)
            {
                if (rover.WantedState.Equals(rover.CurrentState))
                {
                    rover.WantedState = rover.CommandsFactory.TryCreate(item).Execute(rover.CurrentState);
                    rover.TryToChangeState(rover.WantedState);
                }
              
            }
            return rover;
            
        }

        public static void TryToChangeState(this Rover rover , State nextState)
        {

            if (!rover.Field.IsThereObstacleForPosition(nextState.Position) && !rover.Field.IsOutOfBoundaries(nextState.Position))
                rover.CurrentState = new State( new Position(nextState.Position.X, nextState.Position.Y), nextState.Orientation);
        }
       
    }
}
