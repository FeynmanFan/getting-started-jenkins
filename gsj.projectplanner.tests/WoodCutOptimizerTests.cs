namespace gsj.projectplanner.tests
{
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class WoodCutOptimizerTests
    {
        [Test]
        public void Test_CalculateBoardsNeeded()
        {
            // Arrange: Create the optimizer with standard board dimensions
            var optimizer = new WoodCutOptimizer(240, 120);

            // Arrange: Define the pieces needed for the project
            var pieces = new List<(double, double)>
        {
            (60, 40),
            (80, 30),
            (50, 70)
        };

            // Act: Calculate how many boards are needed
            int result = optimizer.CalculateBoardsNeeded(pieces);

            // Assert: Verify that the correct number of boards is returned
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_CalculateBoardsNeeded_ExceedsOneBoard()
        {
            // Arrange: Create the optimizer with standard board dimensions
            var optimizer = new WoodCutOptimizer(240, 120);

            // Arrange: Define more pieces that require more than one board
            var pieces = new List<(double, double)>
        {
            (200, 100),
            (200, 100)
        };

            // Act: Calculate how many boards are needed
            int result = optimizer.CalculateBoardsNeeded(pieces);

            // Assert: Verify that two boards are required
            Assert.That(result, Is.EqualTo(2));
        }
    }

}