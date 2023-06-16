class Pip
{
    public int GridX {get;set;}
    public int GridY {get;set;}
    public int PositionX {get;set;}
    public int PositionY {get;set;}
    public int Square {get;set;}
    public int Row {get;set;}
    public int Column {get;set;}
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
        GridX = x;
        GridY = y;
        PositionX = 4*GridX + 5;
        PositionY = 2*GridY + 2;
        Violate = false;
        Color = ConsoleColor.White;
    }
    public void DisplayPip(bool violate)
    {
        if(Value != 0)
        {
            Violate = violate;
            if (Violate == true)
                Color = ConsoleColor.Red;
            Console.SetCursorPosition(PositionX,PositionY);
            Console.ForegroundColor = Color;
            Console.Write($"{Value}");        
            Console.ForegroundColor = ConsoleColor.White;              
        }
    }
}