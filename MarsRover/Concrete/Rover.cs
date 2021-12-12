using System;
using System.Linq;
using System.Numerics;
using MarsRover.Enums;
using MarsRover.Interfaces;

namespace MarsRover.Concrete
{
    public class Rover : IRover
    {
        public Vector2 Position;
        private Direction _direction;
        private readonly string _commands;

        public Rover(Vector2 position, Direction direction, string commands)
        {
            Position = position;
            _direction = direction;
            _commands = commands;
        }

        /// <summary>
        /// Rover start
        /// </summary>
        /// <returns></returns>
        public string Start()
        {
            _commands.Select(c => (Command) c).ToList().ForEach(TakeAction);
            return $"{Position.X} {Position.Y} {_direction}";
        }

        /// <summary>
        /// Rover move it
        /// </summary>
        /// <param name="command"></param>
        /// <exception cref="ArgumentException"></exception>
        public void TakeAction(Command command)
        {
            switch (command)
            {
                case Command.NONE:
                    break;
                case Command.LEFT:
                    Left();
                    break;
                case Command.RIGHT:
                    Right();
                    break;
                case Command.MOVE:
                    Move();
                    break;
                default:
                    throw new ArgumentException($"Unknown command: {command}");
            }
        }

        /// <summary>
        /// Rover Move
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Move()
        {
            switch (_direction)
            {
                case Direction.NORTH:
                    Position.Y++;
                    break;
                case Direction.EAST:
                    Position.X++;
                    break;
                case Direction.SOUTH:
                    Position.Y--;
                    break;
                case Direction.WEST:
                    Position.X--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Unknown direction: {_direction}");
            }
        }

        /// <summary>
        /// Rover Turn Right 
        /// </summary>
        public void Right()
        {
            _direction++;
            if (_direction == Direction.OUT) _direction = Direction.NORTH;
        }

        /// <summary>
        /// Rover Turn Left 
        /// </summary>
        public void Left()
        {
            _direction--;
            if (_direction == Direction.NONE) _direction = Direction.WEST;
        }
    }
}