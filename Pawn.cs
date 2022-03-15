using System;

namespace Polish_Draughts
{
	class Pawn
	{
		public string color { get; set; }
		public int[] Coordinates { get; set; }
		public bool IsCrowned;
        public int[,] board = {
            { 1, 0, 0, 0, 0, 0, 0, 0, 2, 0},
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 2},
            { 1, 0, 0, 0, 0, 0, 0, 0, 2, 0},
            { 0, 1, 0, 0, 0, 2, 0, 0, 0, 2},
            { 1, 0, 0, 0, 1, 0, 0, 0, 2, 0},
            { 0, 1, 0, 2, 0, 0, 0, 0, 0, 2},
            { 1, 0, 0, 0, 0, 0, 0, 0, 2, 0},
            { 0, 1, 0, 0, 0, 1, 0, 0, 0, 2},
            { 1, 0, 0, 0, 1, 0, 0, 1, 2, 0},
            { 0, 1, 0, 0, 0, 0, 1, 0, 0, 2},
        };
        public Pawn(int row, int col, string color)
        {
            this.color = color;
            Coordinates = new int[2];
            Coordinates[0] = row;
            Coordinates[1] = col;
            //Coordinates[0] = 4;
            //Coordinates[1] = 4;
            //CanMoveto(3, 5, board); //false
            //CanMoveto(2, 6, board); //true
            //CanMoveto(5, 5, board); //true
            //CanMoveto(6, 6, board); //false
            //CanMoveto(4, 5, board); //false
        }
        public bool CanMoveTo(int row,int col, int[,] board) // Board board
		{
            int oppositeMark = 2;
            if (row < 0 || col < 0 || row > board.GetLength(0) - 1 || col > board.GetLength(1) - 1) { return false; }
            if (board[row,col] != 0) { return false; }
            if (Math.Abs(Coordinates[0] - row) > 2 || Math.Abs(Coordinates[1] - col) > 2) { return false; }
            if (Coordinates[0] == row || Coordinates[1] == col) { return false;}
            if (Coordinates[1] < col)
            {
                if (Coordinates[0] - row == 2 && board[Coordinates[0] - 1, Coordinates[1] + 1] == oppositeMark)
                {
                    return true;
                } else if (Coordinates[0] - row == - 2 && board[Coordinates[0] + 1, Coordinates[1] + 1] == oppositeMark) 
                { 
                    return true; 
                }
            } else if (Coordinates[1] > col )
            {
                if (Coordinates[0] - row == 2 && board[Coordinates[0] - 1, Coordinates[1] - 1] == oppositeMark)
                {
                    return true;
                }
                else if (Coordinates[0] - row == -2 && board[Coordinates[0] + 1, Coordinates[1] - 1] == oppositeMark)
                {
                    return true;
                }
            }
            if (color == "Black" && Coordinates[1] - col == -1) 
            { 
                return true; 
            } else if (color == "White" && Coordinates[1] - col ==1) {
                return true;
            }
            return false;
		}

		public bool CanMove(int[,] board) // Board board
        {   if(CanMoveTo(Coordinates[0]-1, Coordinates[1] - 1, board)) { return true; }
            else if (CanMoveTo(Coordinates[0] - 2, Coordinates[1] - 2, board)) { return true; }
            else if (CanMoveTo(Coordinates[0] + 1, Coordinates[1] - 1, board)) { return true; }
            else if (CanMoveTo(Coordinates[0] + 2, Coordinates[1] - 2, board)) { return true; }
            else if (CanMoveTo(Coordinates[0] - 1, Coordinates[1] + 1, board)) { return true; }
            else if (CanMoveTo(Coordinates[0] - 2, Coordinates[1] + 2, board)) { return true; }
            else if (CanMoveTo(Coordinates[0] + 1, Coordinates[1] + 1, board)) { return true; }
            else if (CanMoveTo(Coordinates[0] + 2, Coordinates[1] + 2, board)) { return true; }
            return false;
        }

        // to remove 
        //public void PrintLine(int loopsNumber, string rowStart, string digits, int incrementDigits)
        //{
        //    Console.Write(rowStart);
        //    for (int row = 0; row < loopsNumber; row++)
        //    {
        //        Console.Write(digits, row + incrementDigits);
        //    }
        //    Console.WriteLine();
        //}

        //public char GetPlayerMarker(int currentSpot)
        //{
        //    if (currentSpot == 1)
        //    {
        //        return 'X';
        //    }
        //    return 'O';
        //}

        //public void PrintBoard(int[,] board)
        //{
        //    PrintLine(board.GetLength(1), "     ", "{0}   ", 1);
        //    PrintLine(board.GetLength(1), "   -", new string('-', 4), 1);
        //    for (int row = 0; row < board.GetLength(0); row++)
        //    {
        //        Console.Write($" { Convert.ToChar(row + 65) } |");
        //        for (int col = 0; col < board.GetLength(1); col++)
        //        {
        //            int currentSpot = board[row, col];
        //            char currentSpotMark = ' ';

        //            if (currentSpot != 0)
        //            {
        //                currentSpotMark = GetPlayerMarker(currentSpot);
        //            }
        //            Console.Write($" {currentSpotMark} |");
        //        }
        //        Console.WriteLine();
        //        PrintLine(board.GetLength(1), "   -", new string('-', 4), 1);
        //    }
        //}
    }
}
