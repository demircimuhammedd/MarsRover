using System.Numerics;
using MarsRover.Enums;

namespace MarsRover.Interfaces
{
    public interface IRover
    { 
        string Start();
        void Move();
        void Right();
        void Left();
        void TakeAction(Command command);
    }
}