using System;
namespace FireSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid();
              // Initialise the 2D grid to starting state
              grid.Initialise();

              //Show initial forest forest grid on screen
              grid.ShowGrid();

              //Start fire
              grid.Start();
        }
    }
}