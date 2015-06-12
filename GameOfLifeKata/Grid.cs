namespace GameOfLifeKata
{
    public class Grid : IGrid
    {
        private Cell[,] grid;
        public int X { get; private set; }
        public int Y { get; private set; }

        public Grid(int x, int y)
        {
            grid = new Cell[x, y];
            X = x;
            Y = y;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    grid[i, j] = Cell.Dead;
                }
            }
        }

        public void TurnCellOn(int x, int y)
        {
            if (InBounds(x, y)) grid[x, y] = Cell.Alive;
        }

        public void TurnCellOff(int x, int y)
        {
            if (InBounds(x, y)) grid[x, y] = Cell.Dead;
        }

        public bool IsAlive(int x, int y)
        {
            if (InBounds(x, y)) return (grid[x, y] == Cell.Alive);
            return false;
        }

        public int GetNumberOfNeighbors(int x, int y)
        {
            int count = 0;
            for (int i = x-1; i <= x+1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (InBounds(i, j) && IsAlive(i, j)) count++;
                }
            }
            return count;
        }

        private bool InBounds(int x, int y)
        {
            return (x >= 0 && x < X && y >= 0 && y < Y);
        }
    }
}
