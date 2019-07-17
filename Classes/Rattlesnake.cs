using System;

namespace diggers_and_fliers
{
    public class Rattlesnake : IWalker
    {
        public string name {get; set;}

        public void Move()
        {
            System.Console.WriteLine("The rattlesnake is slithering this way!");
        }
    }
}