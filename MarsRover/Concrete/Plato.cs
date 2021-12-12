using System;
using System.Collections.Generic;
using System.Numerics;
using MarsRover.Interfaces;

namespace MarsRover.Concrete
{
    public class Plato : IPlato
    {
        private readonly Vector2 _position;
        private readonly List<Rover> _rovers = new();

        public Plato(Vector2 position)
        {
            _position = position;
        }

        /// <summary>
        ///  If the starting positions of the rover are outside the plateau, it gives a fall warning.
        /// </summary>
        /// <param name="rover"></param>
        /// <returns></returns>
        public bool FallingExist(Rover rover) =>
            _position.X < rover.Position.X || _position.Y < rover.Position.Y;

        /// <summary>
        /// Rovers Add list
        /// </summary>
        /// <param name="rover"></param>
        /// <exception cref="Exception"></exception>
        public void AddRover(Rover rover)
        {
            if (FallingExist(rover) == false)
            {
                _rovers.Add(rover);
            }
            else
            {
                throw new Exception("I'm falling");
            }
        }

        /// <summary>
        /// Rovers get lists
        /// </summary>
        /// <returns></returns>
        public List<Rover> Rovers() => _rovers;
    }
}