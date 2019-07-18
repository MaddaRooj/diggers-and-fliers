using System;

namespace diggers_and_fliers
{
    public class Finch : IFlier
    {
        public string name {get; set;}
        public string color {get; set;}

        public Finch(string name, string color){
            this.name = name;
            this.color = color;
        }
        public void Move()
        {
            System.Console.WriteLine($"The {color} finch flies above your head.");
        }
    }
}