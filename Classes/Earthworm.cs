using System;

namespace diggers_and_fliers
{
    public class Earthworm : IDigger
    {
        public double Length {get; set;}
        public void Move(){
            System.Console.WriteLine("The earthworm wriggles in the dirt.");
        }
    }
}