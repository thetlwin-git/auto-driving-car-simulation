# Auto Driving Car Simulation

This project simulates an auto-driving car aiming to compete against Tesla. The prototype car is operational but in a rather primitive state. It includes features with coordinates denoting positions on a field, where the bottom left position is (0, 0), and the top right position is denoted as (width, height).

### Features
- **L:** Rotates the car by 90 degrees to the left
- **R:** Rotates the car by 90 degrees to the right
- **F:** Moves forward by 1 grid point

The car faces a direction, following the usual map convention. For instance, a car at position (1, 2) facing North, after moving forward by 1 grid point, will end up at (1, 3) while still facing North.

## Sample Input
The input comprises 3 lines:
1. Width and height of the field.
2. Current position and facing direction of the car.
3. Subsequent commands the car will execute.

```
10 10
1 2 N
FFRFFFRRLF
```
In the given example, with a field of size 10 by 10, the car starts at position (1, 2) facing North. Executing the commands `FFRFFFRRLF` sequentially, determine where the car ends up and its facing direction.

If the car attempts to move out of the boundary, that command is ignored.

## Sample Output
Based on the example input, the output would be:

```
4 3 S
```

The project includes unit tests covering the core functionalities of the application and follows the DDD (Domain-Driven Design) principles for project folder structure organization, making it easy to understand and maintain.

### Domain Layer
The `AutoDrivingCarSimulation.Domain` project encapsulates logic and properties related to the auto-driving car within the domain layer of the application.

### Application Layer
The `AutoDrivingCarSimulation.Application` project manages application-specific functionalities and services for the auto-driving car simulation.

### Unit Testing
The `AutoDrivingCarSimulation.Tests` project enables implementation of unit tests using the NUnit framework to validate the application's functionalities and behaviors.

### Presentation
The `AutoDrivingCarSimulation.Main` project provides a presentation layer for the simulation, allowing user interaction or demonstration of the auto-driving car functionalities.