using System;

namespace diggers_and_fliers
{
    public class Parakeet : IFlier
    {
        public string color {get; set;}

        public void Move()
        {
            System.Console.WriteLine("The parakeet flies around the room");
        }
    }
}