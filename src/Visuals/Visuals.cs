public class TextColours
{
    public static String Balck()
    {
        return "\x1b[1;30m";
    }

    public static String Red()
    {
        return "\x1b[1;31m";
    }

    public static String Green()
    {
        return "\x1b[1;32m";
    }

    public static String Yellow()
    {
        return "\x1b[1;33m";
    }

    public static String Blue()
    {
        return "\x1b[1;34m";
    }

    public static String Magenta()
    {
        return "\x1b[1;35m";
    }

    public static String Cyan()
    {
        return "\x1b[1;36m";
    }

    public static String White()
    {
        return "\x1b[1;37m";
    }
    
    public static String BrightBlack()
    {
        return "\x1b[1;90m";
    }

    public static String BrightRed()
    {
        return "\x1b[1;91m";
    }

    public static String BrightGreen()
    {
        return "\x1b[1;92m";
    }

    public static String BrightYellow()
    {
        return "\x1b[1;93m";
    }

    public static String BrightBlue()
    {
        return "\x1b[1;94m";
    }

    public static String BrightMagenta()
    {
        return "\x1b[1;95m";
    }

    public static String BrightCyan()
    {
        return "\x1b[1;96m";
    }

    public static String BrightWhite()
    {
        return "\x1b[1;97m";
    }
}

public static class Visuals
{
    private static string buffer = "", lastBuffer = "";
    private static int maxUpdateRate = 1, currentUpdateRate = 0;
    public static void Clear()
    {
        Console.Clear();
    }

    public static void Render()
    {
        buffer += QueueCharactersRender();

        if (lastBuffer == buffer)
        {
            buffer = "";
            return;
        }
        Clear();
        Console.Write(buffer);
        Console.Out.Flush();
        lastBuffer = buffer;
        buffer = "";
    }

    private static string ResetColour()
    {
        //means we reset the colour usage is like <HTML></HTML>
        //after calling a colour you must end the colour
        return "\x1b[1;0m";
    }

    public static string QueueCharactersRender()
    {
        string playerBuffer = Character.GetPlayerColour();
        playerBuffer += String.Format("\x1b[{0};{1}f{2}", Character.GetPosX(), Character.GetPosY(), Character.GetSymbol());
        playerBuffer += ResetColour();
        return playerBuffer;
    }
}