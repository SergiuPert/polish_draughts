using System;

namespace Polish_Draughts
{
	class Game
	{
		private Board board;
		public Game presentation()
		{
			Console.WriteLine("Welcome to Polish Draughts");
			Console.WriteLine("This is a two players game, black and white, hat take turns moving their pieces");
			Console.WriteLine("Pieces may be moved one square diagonaly if the destination square is free,");
			Console.WriteLine("or jumped over another piece diagonaly if the square behind is free");
			Console.WriteLine("If you jump over your oponet's piece, it is captured - removed from the game.");
			Console.WriteLine("Plyers alternate and white starts");
			Console.WriteLine("The aim is to capture more oponent pieces than you loose and move your surviving pieces to the othr side of the board");
			return this;
		}
		public void Start()
		{
			int n=10;
			bool b=false;
			while (!b)
			{
				Console.WriteLine("Please enter desired size for the board (as integer beteen 10 and 20)");
				b = int.TryParse(Console.ReadLine(), out n);
				if (!b) Console.WriteLine("PAY ATTENTION, WILL YOU?");
			}
			board = new Board(n);
		}
		public Game Round(int player)
		{
			string c = (player == 1) ? "White" : "Black";
			bool b;
			string input;
			int col=0, row=0;
			for(;;)
			{
				b = false;
				board.PrintBoard();
				Console.WriteLine($"Player {player}, is your turn to move. Remember that your color is {c}");
				while (!b)
				{
					Console.WriteLine("Select pawn to move (Letter-Number format, please)");
					input = Console.ReadLine();
					if (input == "quit") Environment.Exit(0);
					col = input[0] - 'A';
					if (col < 0 || col >= board.size) continue;
					if (!int.TryParse(input.Substring(1), out row)) continue;
					if (board.field[row, col] != null)
					{
						if (board.field[row, col].color[0] == c[0]) b = true;
						else Console.WriteLine("That's not your pawn! PAY ATTENTION! Again!");
					}
					else Console.WriteLine("You don't have a pawn there! Again!");
				}
				Pawn p = board.field[row, col];
				b = false;
				while (!b)
				{
					Console.WriteLine("Enter destination field (Letter-Number format, please)");
					input = Console.ReadLine();
					if (input == "quit") Environment.Exit(0);
					col = input[0] - 'A';
					if (col < 0 || col >= board.size) continue;
					if (!int.TryParse(input.Substring(1), out row)) continue;
					if (board.field[row, col] !=null)
					{
						Console.WriteLine("That field is ocupied! PAY ATTENTION! Again!");
						continue;
					}
					b = true;
				}
				if (!p.CanMoveTo( row,col, ref board)) Console.WriteLine("Invalid move. Check the rules and try again");
				else
				{
					MovePawn(p.Coordinates[0], p.Coordinates[1], row, col);
					Console.Clear();
					break;
				}
			}
			return this;
		}
		public void MovePawn(int x1, int y1, int x2, int y2)
		{
			board.MovePawn(x1, y1, x2, y2);
			if (x2 - x1 == 2)
			{
				if (y2 - y1 == 2) board.RemovePawn(x1 + 1, y1 + 1);
				else board.RemovePawn(x1 + 1, y1 - 1);
			}
			if (x1 - x2 == 2)
			{
				if (y2 - y1 == 2) board.RemovePawn(x1 - 1, y1 + 1);
				else board.RemovePawn(x1 - 1, y1 - 1);
			}
		}
		public int CheckForWin()
		{
			int countBlack = 0, countWhite = 0;
			bool canMove = false;
			for(int i=0;i<board.size;i++) for(int j = 0; j < board.size; j++)
				{
					Pawn p = board.field[i, j];
					if (p == null) continue;
					if (p.color == "W") countWhite++; else countBlack++;
					if (!canMove) canMove = p.CanMove(ref board);
				}
			if (countBlack != 0 && countWhite==0) return 2;
			if (countWhite != 0 && countBlack==0) return 1;
			if (!canMove) return -1;
			return 0;
		}
		public void AnnounceResult(int gameCode)
		{
			switch (gameCode)
			{
				case -1: { Console.WriteLine("Game is a draw. Better luck next time."); break; }
				case 1: { Console.WriteLine("Congratulation player 1, you won."); break; }
				case 2: { Console.WriteLine("Congratulation player 2, you won."); break; }
			}
		}
	}
}
