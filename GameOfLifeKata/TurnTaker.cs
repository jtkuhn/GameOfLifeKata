using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLifeKata
{
    public class TurnTaker
    {
        private Grid currentGrid;
        private Grid futureGrid;

        public TurnTaker(Grid grid)
        {
            currentGrid = grid;
            futureGrid = new Grid(grid.X, grid.Y);
        }


    }
}
