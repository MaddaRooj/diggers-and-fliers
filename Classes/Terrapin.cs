using System;

namespace diggers_and_fliers
{
    public class Terrapin : IWalker
    {
        public string name {get; set;}

        public void Move()
        {
            System.Console.WriteLine("Your turtle is running away!");
        }
    }
}