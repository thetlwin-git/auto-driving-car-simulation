using AutoDrivingCarSimulation.Application;

public class Program
{
    public static void Main()
    {
        string? input = null;

    dimensions:
        Console.Write("Enter the values for dimensions (width height): ");
        input = Console.ReadLine();

        if (input == null || input.Split().Length < 2)
        {
            Console.WriteLine("The input values for dimensions (width height) are incorrect.");
            goto dimensions;
        }

        string[] dimensions = input.Split();
        int width = int.Parse(dimensions[0]);
        int height = int.Parse(dimensions[1]);

    initialPosition:
        Console.Write("Enter the values for the initial position (x y direction): ");
        input = Console.ReadLine();

        if (input == null || input.Split().Length < 3)
        {
            Console.WriteLine("The input values for the initial position (x y direction) are incorrect.");
            goto initialPosition;
        }

        string initialPosition = input;

    commands:
        Console.Write("Enter the subsequent commands: ");
        input = Console.ReadLine();

        if (input == null || input.Length < 1)
        {
            Console.Write("The input value for subsequent commands is incorrect.");
            goto commands;
        }

        string commands = input;

        AutoDrivingCarService carService = new AutoDrivingCarService();
        string finalPosition = carService.ExecuteCommands(width, height, initialPosition, commands);

        Console.WriteLine("Output: {0}", finalPosition);
    }
}