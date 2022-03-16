using System;

namespace Polish_Draughts
{
	class Program
	{
		static void Main(string[] args) {
			//Game game=new Game();
			//for(;;)
			//{
			//	int endGame = 0;
			//	game.presentation().Start();
			//	for(int player = 1;endGame == 0; player=(player+1)%2) endGame = game.Round(player).CheckForWin();
			//	game.AnnounceResult(endGame);
			//	Console.WriteLine("Game Over. Do you wish to quit?");
			//	if (Console.ReadLine() == "yes") Environment.Exit(0);
			//}

		    int[,] board = {
				    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
				    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
				    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
				    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
				    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
				    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
				    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
				    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
				    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
				    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			    };
            
		}
        public void PrintLine(int loopsNumber, string rowStart, string digits, int incrementDigits)
        {
            Console.Write(rowStart);
            for (int row = 0; row < loopsNumber; row++)
            {
                Console.Write(digits, row + incrementDigits);
            }
            Console.WriteLine();
        }

        public char GetPlayerMarker(int currentSpot)
        {
            if (currentSpot == 1)
            {
                return 'X';
            }
            return 'O';
        }

        public void PrintBoard(int[,] board)
        {
            PrintLine(board.GetLength(1), "     ", "{0}   ", 1);
            PrintLine(board.GetLength(1), "   -", new string('-', 4), 1);
            for (int row = 0; row < board.GetLength(0); row++)
            {
                Console.Write($" { Convert.ToChar(row + 65) } |");
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    int currentSpot = board[row, col];
                    char currentSpotMark = ' ';

                    if (currentSpot != 0)
                    {
                        currentSpotMark = GetPlayerMarker(currentSpot);
                    }
                    Console.Write($" {currentSpotMark} |");
                }
                Console.WriteLine();
                PrintLine(board.GetLength(1), "   -", new string('-', 4), 1);
            }
        }
    }
}
