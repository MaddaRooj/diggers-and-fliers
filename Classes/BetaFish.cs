using System;

namespace diggers_and_fliers
{
    public class BettaFish : ISwimmer
    {
        public string color {get; set;}
        public void Move()
        {
            System.Console.WriteLine($"The {color} betta fish swims in his tank.");
        }
    }
}