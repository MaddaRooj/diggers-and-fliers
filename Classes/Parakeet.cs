using System;

namespace diggers_and_fliers
{
    public class Parakeet : IFlier
    {
        public string name {get; set;}
        public string color {get; set;}

        public Parakeet(string name, string color){
            this.name = name;
            this.color = color;
        }
        public void Move()
        {
            System.Console.WriteLine("The parakeet flies around the room");
        }
    }
}