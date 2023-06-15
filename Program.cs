Pip[,] grid = new Pip[9,9];
Random rand = new Random();
int value;
Console.Clear();
for(int i = 0; i< 9; i++)
{
    for(int j = 0; j<9 ;j++)
    {
        
        value = rand.Next(0,10);
        grid[i,j] = new Pip(value,6*i, 3*j);
        grid[i,j].DisplayPip(false);
    }
}