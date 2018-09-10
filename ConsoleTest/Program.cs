using System;
using MarsRover;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var rover = new Rover();
            var rover1 = rover.TryToExecuteSequenceOfCommands("MMRML");
            var x = 3;

        }
    }
}
