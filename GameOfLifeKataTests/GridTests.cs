using GameOfLifeKata;
using NUnit.Framework;

namespace GameOfLifeKataTests
{
    [TestFixture]
    public class GridTests
    {
        private Grid grid;

        [SetUp]
        public void Setup()
        {
            grid = new Grid(5, 5);
        }

        [Test]
        public void WhenInitialized_AllCellsAreDead()
        {
            Assert.That(grid.IsAlive(0, 0), Is.False);
            Assert.That(grid.IsAlive(1, 1), Is.False);
            Assert.That(grid.IsAlive(4, 4), Is.False);
        }

        [Test]
        public void WhenACellIsTurnedOn_ItIsOn()
        {
            Assert.That(grid.IsAlive(0, 0), Is.False);
            grid.TurnCellOn(0, 0);
            Assert.That(grid.IsAlive(0, 0));
        }

        [Test]
        public void WhenACellIsTurnedOff_ItIsOff()
        {
            grid.TurnCellOn(0, 0);
            Assert.That(grid.IsAlive(0, 0));
            grid.TurnCellOff(0, 0);
            Assert.That(grid.IsAlive(0, 0), Is.False);
        }

        [Test]
        public void GetNumberOfNeighborsWith0Neighbors_ReturnsZero()
        {
            Assert.AreEqual(0, grid.GetNumberOfNeighbors(0, 0));
        }

        [Test]
        public void GetNumberOfNeighborsWith1Neighbor_ReturnsOne()
        {
            grid.TurnCellOn(0, 1);
            Assert.AreEqual(1, grid.GetNumberOfNeighbors(0, 0));
        }

        [Test]
        public void GetNumberOfNeighborsWith2Neighbors_ReturnsTwo()
        {
            grid.TurnCellOn(0, 1);
            grid.TurnCellOn(1, 0);
            Assert.AreEqual(2, grid.GetNumberOfNeighbors(0, 0));
        }
    }
}
