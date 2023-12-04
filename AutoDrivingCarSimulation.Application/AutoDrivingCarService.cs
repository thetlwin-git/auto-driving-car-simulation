using AutoDrivingCarSimulation.Domain;

namespace AutoDrivingCarSimulation.Application
{
    public class AutoDrivingCarService
    {
        public string ExecuteCommands(int width, int height, string initialPosition, string commands)
        {
            string[] initialPositionDetails = initialPosition.Split(' ');
            int x = int.Parse(initialPositionDetails[0]);
            int y = int.Parse(initialPositionDetails[1]);
            char direction = char.Parse(initialPositionDetails[2]);

            AutoDrivingCar car = new AutoDrivingCar(width, height, x, y, direction);
            car.Move(commands);

            return car.GetPosition();
        }
    }
}