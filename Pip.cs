class Pip
{
    public int X {get;set;}
    public int Y {get;set;}
    public int Value {get;set;}
    public ConsoleColor Color {get;set;}
    public bool Visibility {get;set;}
    public bool Violate {get;set;}
    public Pip (int value, int x, int y)
    {
        if(value > 9 || value < 0)
            Value = 0;
        else 
            Value = value;
        if(value == 0)
            Visibility = false;
        else
            Visibility = true;
        X = x;
        Y = y;
        Violate = false;
        Color = ConsoleColor.White;
    }
    public void DisplayPip(bool violate)
    {
        Violate = violate;
        if (Violate == true)
            Color = ConsoleColor.Red;
        Console.SetCursorPosition(X,Y);
        Console.WriteLine("┌────┐");
        Console.SetCursorPosition(X,Y+1);
        Console.Write("│");
        Console.ForegroundColor = Color;
        Console.Write($" {Value}  ");        
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("│");
        Console.SetCursorPosition(X,Y+2);
        Console.WriteLine("└────┘"); 
        
        
    }
}