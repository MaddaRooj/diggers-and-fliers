using System;

namespace diggers_and_fliers
{
    public class Ant : IWalker
    {
        public string name {set; get;}
        public void Move(){
            System.Console.WriteLine($"{name} the ant carries food back to his farm.");
        }
    }
}