public  class Draw
{
    public static void EmptyBoard(int x, int y)
    {
        Console.Clear();
        Console.SetCursorPosition(x,y);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("┌───┬───┬───╥───┬───┬───╥───┬───┬───┐");
        Console.SetCursorPosition(x,y+1);
        Console.WriteLine("│   │   │   ║   │   │   ║   │   │   │");
        Console.SetCursorPosition(x,y+2);
        Console.WriteLine("├───┼───┼───╫───┼───┼───╫───┼───┼───┤");
        Console.SetCursorPosition(x,y+3);
        Console.WriteLine("│   │   │   ║   │   │   ║   │   │   │");
        Console.SetCursorPosition(x,y+4);
        Console.WriteLine("├───┼───┼───╫───┼───┼───╫───┼───┼───┤");
        Console.SetCursorPosition(x,y+5);
        Console.WriteLine("│   │   │   ║   │   │   ║   │   │   │");
        Console.SetCursorPosition(x,y+6);
        Console.WriteLine("╞═══╪═══╪═══╬═══╪═══╪═══╬═══╪═══╪═══╡");
        Console.SetCursorPosition(x,y+7);
        Console.WriteLine("│   │   │   ║   │   │   ║   │   │   │");
        Console.SetCursorPosition(x,y+8);
        Console.WriteLine("├───┼───┼───╫───┼───┼───╫───┼───┼───┤");
        Console.SetCursorPosition(x,y+9);
        Console.WriteLine("│   │   │   ║   │   │   ║   │   │   │");
        Console.SetCursorPosition(x,y+10);
        Console.WriteLine("├───┼───┼───╫───┼───┼───╫───┼───┼───┤");
        Console.SetCursorPosition(x,y+11);
        Console.WriteLine("│   │   │   ║   │   │   ║   │   │   │");
        Console.SetCursorPosition(x,y+12);
        Console.WriteLine("╞═══╪═══╪═══╬═══╪═══╪═══╬═══╪═══╪═══╡");
        Console.SetCursorPosition(x,y+13);
        Console.WriteLine("│   │   │   ║   │   │   ║   │   │   │");
        Console.SetCursorPosition(x,y+14);
        Console.WriteLine("├───┼───┼───╫───┼───┼───╫───┼───┼───┤");
        Console.SetCursorPosition(x,y+15);
        Console.WriteLine("│   │   │   ║   │   │   ║   │   │   │");
        Console.SetCursorPosition(x,y+16);
        Console.WriteLine("├───┼───┼───╫───┼───┼───╫───┼───┼───┤");
        Console.SetCursorPosition(x,y+17);
        Console.WriteLine("│   │   │   ║   │   │   ║   │   │   │");
        Console.SetCursorPosition(x,y+18);
        Console.WriteLine("└───┴───┴───╨───┴───┴───╨───┴───┴───┘");
    }
}