namespace GameOfLifeKata
{
    public interface IGrid
    {
        bool IsAlive(int x, int y);
        int GetNumberOfNeighbors(int x, int y);
    }
}
