class Program
{    static void Init()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Character.Create(1, 1, '@', TextColours.Blue());
    }

    static void Update()
    {
        while(true)
        {
            PlayerControls();
            HandleAI();
            Visuals.Render();
            Thread.Sleep(32);
        }
    }

    static void HandleQuiting(List<KeyCode> keys)
    {
        if(keys.Contains(KeyCode.Esc))
        {
            Environment.Exit(0);
        }
    }

    static void PlayerControls()
    {
        if (InputSystem.HasPressedKey())
        {
            var keys = InputSystem.GetInputs();
            HandleQuiting(keys);
            Character.UpdatePosition(keys);
        }
    }

    static void HandleAI()
    {
        //Console.WriteLine("Handle AI");
    }

    static void Main()
    {
        Init();
        Update();
    }
}
