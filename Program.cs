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
            var bettaFish = new BettaFish(){
                color = "blue"
            };
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
            var finch = new Finch(){
                color = "purple"
            };
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
            var parakeet = new Parakeet();
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

            var groundAnimals = new List<IWalker>(){
                ant, mouse, terrapin, gerbil, rattlesnake, copperhead
            };
            foreach( var animal in groundAnimals)
            {
                System.Console.WriteLine($"{animal.name}");
            }
        }
    }
}
