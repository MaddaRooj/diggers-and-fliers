using System;

namespace diggers_and_fliers
{
    public class Copperhead : IWalker
    {
        public string name {get; set;}
        public void Move(){
            System.Console.WriteLine("The copperhead slithers swiftly into the creekbed.");
        }
    }
}