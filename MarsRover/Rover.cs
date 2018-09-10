using System;

namespace MarsRover
{
    public class Rover
    {
        public State CurrentState { get; set; }

        public State WantedState { get; set; }

        public Field Field { get; set; }

        public CommandsFactory CommandsFactory = new CommandsFactory();

        public Rover()
        {
            CurrentState = new State(new Position(0,0), Orientation.N);
            WantedState = CurrentState;
            Field = new Field(10, 10);
        }

        public Rover(State state)
        {
            CurrentState = state;
            WantedState = CurrentState;
            Field = new Field(10, 10);
        }


      
    }
}
