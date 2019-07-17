using System;

namespace diggers_and_fliers
{
    public class Mouse : IWalker
    {
        public string name {get; set;}
        public void Move()
        {
            System.Console.WriteLine("The mouse scurries back into the hole in the wall.");
        }
    }
}