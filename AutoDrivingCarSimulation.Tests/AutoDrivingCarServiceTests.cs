using AutoDrivingCarSimulation.Application;

namespace AutoDrivingCarSimulation.Tests
{
    [TestFixture]
    public class AutoDrivingCarServiceTests
    {
        [Test]
        public void ExecuteCommands_CarMovesWithinBounds_Successfully()
        {
            AutoDrivingCarService carService = new AutoDrivingCarService();
            string finalPosition = carService.ExecuteCommands(5, 5, "2 2 N", "FFRFFFRRLF");

            Assert.That(finalPosition, Is.EqualTo("4 3 S"));
        }

        [Test]
        public void ExecuteCommands_CarStaysWithinBounds_IgnoreOutOfBoundsCommands()
        {
            AutoDrivingCarService carService = new AutoDrivingCarService();
            string finalPosition = carService.ExecuteCommands(3, 3, "0 0 S", "FFRF");

            Assert.That(finalPosition, Is.Not.EqualTo("0 0 S"));
        }

        [Test]
        public void ExecuteCommands_CarRotatesLeft_Successfully()
        {
            AutoDrivingCarService carService = new AutoDrivingCarService();
            string finalPosition = carService.ExecuteCommands(5, 5, "2 2 N", "L");

            Assert.That(finalPosition, Is.EqualTo("2 2 W"));
        }

        [Test]
        public void ExecuteCommands_CarRotatesRight_Successfully()
        {
            AutoDrivingCarService carService = new AutoDrivingCarService();
            string finalPosition = carService.ExecuteCommands(5, 5, "2 2 N", "R");

            Assert.That(finalPosition, Is.EqualTo("2 2 E"));
        }
    }
}