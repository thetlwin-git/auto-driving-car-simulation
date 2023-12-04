namespace AutoDrivingCarSimulation.Domain
{
    public class AutoDrivingCar
    {
        private int width;
        private int height;
        private int x;
        private int y;
        private char direction;

        public AutoDrivingCar(int width, int height, int x, int y, char direction)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

        public void Move(string commands)
        {
            char[] directions = { 'N', 'E', 'S', 'W' };
            int[] dx = { 0, 1, 0, -1 };
            int[] dy = { 1, 0, -1, 0 };

            int currentDirectionIndex = Array.IndexOf(directions, direction);

            foreach (char command in commands)
            {
                if (command == 'L')
                {
                    currentDirectionIndex = (currentDirectionIndex + 3) % 4; // Equivalent to rotating 90 degrees left
                }
                else if (command == 'R')
                {
                    currentDirectionIndex = (currentDirectionIndex + 1) % 4; // Equivalent to rotating 90 degrees right
                }
                else if (command == 'F')
                {
                    int newX = x + dx[currentDirectionIndex];
                    int newY = y + dy[currentDirectionIndex];

                    if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                    {
                        x = newX;
                        y = newY;
                    }
                }
            }

            direction = directions[currentDirectionIndex];
        }

        public string GetPosition()
        {
            return $"{x} {y} {direction}";
        }
    }
}