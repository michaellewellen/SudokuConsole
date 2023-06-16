class Sudoku
{
    int SRN;
    Random rand = new Random();
    int N {get;set;}
    int K {get;set;} 
    public Pip[,]? Grid {get;set;}
    public Sudoku (int n,int k)
    {
        N = n;
        K = k;
        Grid = new Pip[N,N];
        SRN = (int)Math.Sqrt(N);
        for(int i = 0; i<N;i++)
            for(int j = 0; j<N; j++)
                Grid[i,j]=new Pip(0,i,j);
    }
    public void DrawPips()
    {
        for(int i = 0; i<N; i++)
            for (int j=0;j<N;j++)
                Grid![i,j].DisplayPip(false);
    }
    // following the rules of Sudoku, fill all of the squares
    public void buildBoard()
    {
        // Fill the big diagonal since you don't need to check the rules
        fillDiagonal();
        // Fill the remaining blocks using Sudoku rules
        fillRemaining(0,SRN);
        // remove K squares, later include logic to confirm unique solutions
        removeTiles();
    }
    void fillDiagonal()
    {
        // This method fills the three diagonal boxes
        for (int i = 0; i< N; i += SRN)
        {
            fillBox(i,i);
        }
    }
    void fillBox(int row, int col)
    {
        int number;
        for (int i = 0; i<SRN; i++)
        {
            for(int j = 0; j<SRN; j++)
            {
                do
                {
                    number = rand.Next(1,N+1);
                }
                while(!uniqueInBox(row,col,number));
                Grid![i+row,j+col].Value = number;
            }
        }
    }
    bool uniqueInBox(int rowStart,int colStart, int val)
    {
        for(int i = 0; i<SRN; i++)
            for(int j = 0; j<SRN; j++)
                if(Grid![rowStart + i, colStart+j].Value == val)
                    return false;
        return true;
    }
    bool uniqueInRow(int rowStart, int val)
    {
        for (int j = 0; j<N; j ++)
            if(Grid![rowStart,j].Value == val)
                return false;
        return true;
    }
    bool uniqueInColumn(int colStart, int val)
    {
        for (int i = 0; i<N; i++)
            if(Grid![i,colStart].Value == val)
                return false;
        return true;
    }
    bool isSafeSquare(int i, int j, int num)
    {
        return (uniqueInBox(i-i%SRN,j-j%SRN,num) && 
                uniqueInRow(i,num) &&
                uniqueInColumn(j,num));
    }
    bool fillRemaining(int i, int j)
    {
        // if we are at the end of the matrix
        if(i == N-1 && j == N)
            return true;
        // if at then end, go to the next row
        if (j == N)
        {
            i += 1;
            j = 0;
        }
        // if the square is filled, skip it
        if (Grid![i,j].Value !=0)
            return fillRemaining(i,j+1);
        
        for (int num = 1; num<=N; num++)
        {
            if(isSafeSquare(i,j,num))
            {
                Grid![i,j].Value = num;
                if (fillRemaining(i,j+1))
                    return true;
                Grid[i,j].Value = 0;
            }
        }
        // if no valid value can be found for that square, backtrack
        return false;
    }
    void removeTiles()
    {

    }

}