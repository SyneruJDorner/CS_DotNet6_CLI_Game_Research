public static class Character
{
    public class ConsoleApp
    {
        public int lines;
        public int columns;
        public int aspectRatio;

        public ConsoleApp()
        {
            lines = Console.WindowHeight;
            columns = Console.WindowWidth;
            aspectRatio = ((int)((float)columns / (float)lines));
            aspectRatio /= (aspectRatio / 2);
        }
    }
    private static int posX;
    private static int posY;
    private static char symbol;
    private static string colour = "";

    public static void Create(int X, int Y, char symbol, string colour)
    {
        Character.posX = X;
        Character.posY = Y;
        Character.symbol = symbol;
        Character.colour = colour;
    }

    public static int GetPosX()
    {
        return Character.posX;
    }

    public static int GetPosY()
    {
        return Character.posY;
    }

    public static char GetSymbol()
    {
        return Character.symbol;
    }

    public static string GetPlayerColour()
    {
        return Character.colour;
    }

    public static void UpdatePosition(List<KeyCode> keys)
    {
        ConsoleApp worldSize = new ConsoleApp();

        foreach (var key in keys)
        {
            if (key == KeyCode.UpArrow) //Move up
            {
                Character.posX--;
                if (Character.posX < 1)
                    Character.posX = 1;
            }

            if (key == KeyCode.DownArrow) //Move down
            {
                Character.posX++;
                if (Character.posX > worldSize.lines)
                    Character.posX = worldSize.lines;
            }

            if (key == KeyCode.LeftArrow) //Move left
            {
                Character.posY -= worldSize.aspectRatio;
                if (Character.posY < 1)
                    Character.posY = 1;
            }

            if (key == KeyCode.RightArrow) // Move right
            {
                Character.posY += worldSize.aspectRatio;
                if (Character.posY > worldSize.columns)
                    Character.posY = worldSize.columns;
            }
        }
    }

}
