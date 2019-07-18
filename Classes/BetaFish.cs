using System;

namespace diggers_and_fliers
{
    public class BettaFish : ISwimmer
    {
        public string name {get; set;}
        public string color {get; set;}

        public BettaFish(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public void Move()
        {
            System.Console.WriteLine($"The {color} betta fish swims in his tank.");
        }
    }
}