using System;
using System.Numerics;
using MarsRover.Concrete;
using MarsRover.Enums;

namespace MarsRover
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Plato plato = new(new Vector2(5, 5));
            Rover roverNeo = new(new Vector2(1, 2), Direction.NORTH, "LMLMLMLMM");
            Rover roverTrinity = new(new Vector2(3, 3), Direction.EAST, "MMRMMRMRRM");

            plato.AddRover(roverNeo);
            plato.AddRover(roverTrinity);

            plato.Rovers().ForEach(c =>
            {
                string output = c.Start();
                Console.WriteLine(output);
            });

            Console.ReadKey();
        }
    }
}