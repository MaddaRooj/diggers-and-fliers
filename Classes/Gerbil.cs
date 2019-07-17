using System;

namespace diggers_and_fliers
{
    public class Gerbil : IWalker
    {
        public string name {get; set;}
        public void Move()
        {
            System.Console.WriteLine($"Your gerbil {name} is running on his wheel.");
        }
    }
}