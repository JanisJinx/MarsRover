using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class CommandsFactory
    {
        public Command TryCreate(char c)
        {
            switch (c)
            {
                case 'R':
                    return new TurnRight();
                case 'L':
                    return new TurnLeft();
                case 'M':
                    return new Forward();
            }
            return null;
        }
    }
}
