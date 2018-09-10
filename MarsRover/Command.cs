using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public abstract class Command
    {
        public abstract State Execute(State state);
    }
}
