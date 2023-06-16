
Console.Clear();
Draw.EmptyBoard(3,1);
Sudoku game = new Sudoku(9,10);
game.buildBoard();
game.DrawPips();
Console.SetCursorPosition(0,21);
Console.ReadKey();