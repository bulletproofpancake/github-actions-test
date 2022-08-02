using NUnit.Framework;

namespace Tests
{
    public class PointCalculatorTests
    {
        [Test]
        public void CalculateTotalPoints_Test()
        {
            // ARRANGE
            var pointCalculator = new PointCalculator();
            var killedEnemies = 24;
            var killedVillagers = 3;
            var multiplicator = 2;
            var expectedPoints = (24 * 100 + 2 * 500 - 3 * 100) * 2;
            
            // ACT
            var points = pointCalculator.CalculateTotalPoints(
                killedEnemies,
                killedVillagers,
                multiplicator
            );

            // ASSERT
            Assert.That(points,Is.EqualTo(expectedPoints));
        }
    }
}
