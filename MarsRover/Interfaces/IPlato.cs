using System.Collections.Generic; 
using MarsRover.Concrete;

namespace MarsRover.Interfaces
{
    public interface IPlato
    {
        bool FallingExist(Rover rover);
        void AddRover(Rover rover);
        List<Rover> Rovers();
    }
}