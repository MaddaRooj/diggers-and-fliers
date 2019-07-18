using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            var ant = new Ant(){
                name = "Henry"
            };
            ant.Move();

            Console.WriteLine();
            var bettaFish = new BettaFish("Steve", "Blue");
            bettaFish.Move();

            Console.WriteLine();
            var copperhead = new Copperhead(){
                name = "Carl"
            };
            copperhead.Move();

            Console.WriteLine();
            var earthworm = new Earthworm();
            earthworm.Move();

            Console.WriteLine();
            var finch = new Finch("Heath", "blue");
            finch.Move();

            Console.WriteLine();
            var gerbil = new Gerbil(){
                name = "Germaine"
            };
            gerbil.Move();

            Console.WriteLine();
            var mouse = new Mouse(){
                name = "Jerry"
            };
            mouse.Move();

            Console.WriteLine();
            var parakeet = new Parakeet("Tim", "yellow");
            parakeet.Move();

            Console.WriteLine();
            var rattlesnake = new Rattlesnake(){
                name = "Rick"
            };
            rattlesnake.Move();

            Console.WriteLine();
            var terrapin = new Terrapin(){
                name = "Shelldon"
            };
            terrapin.Move();

            System.Console.WriteLine();
            var groundAnimals = new List<IWalker>(){
                ant, mouse, terrapin, gerbil, rattlesnake, copperhead
            };
            System.Console.WriteLine("Land animals:");
            foreach( var animal in groundAnimals)
            {
                System.Console.WriteLine($"{animal.name} the {animal.GetType().ToString().Split(".")[1]}");
            }

            System.Console.WriteLine();
            var aquaticAnimals = new List<ISwimmer>(){
                bettaFish
            };
            System.Console.WriteLine("Aquatic animals:");
            foreach( var animal in aquaticAnimals)
            {
                System.Console.WriteLine($"{animal.name} the {animal.GetType().ToString().Split(".")[1]}");
            }

            System.Console.WriteLine();
            var flyingAnimals = new List<IFlier>(){
                finch, parakeet
            };
            System.Console.WriteLine("Flying animals:");
            foreach( var animal in flyingAnimals)
            {
                System.Console.WriteLine($"{animal.name} the {animal.GetType().ToString().Split(".")[1]}");
            }
        }
    }
}
