using System;

namespace diggers_and_fliers
{
    public class Finch : IFlier
    {
        public string color {get; set;}

        public void Move()
        {
            System.Console.WriteLine($"The {color} finch flies above your head.");
        }
    }
}