using System;

namespace Polish_Draughts
{
	//class Game
	//{
	//	private Board board;
	//	public Game presentation()
	//	{
	//		Console.WriteLine("Welcome to Polish Draughts");
	//		Console.WriteLine("This is a two players game, black and white, hat take turns moving their pieces");
	//		Console.WriteLine("Pieces may be moved one square diagonaly if the destination square is free,");
	//		Console.WriteLine("or jumped over another piece diagonaly if the square behind is free");
	//		Console.WriteLine("If you jump over your oponet's piece, it is captured - removed from the game.");
	//		Console.WriteLine("Plyers alternate and white starts");
	//		Console.WriteLine("The aim is to capture more oponent pieces than you loose and move your surviving pieces to the othr side of the board");
	//		return this;
	//	}
	//	public void Start()
	//	{
	//		int boardSize=10;
	//		bool flag=false;
	//		while (!flag)
	//		{
	//			Console.WriteLine("Please enter desired size for the board (as integer beteen 10 and 20)");
	//			flag = int.TryParse(Console.ReadLine(), out boardSize);
	//			if (!flag) Console.WriteLine("PAY ATTENTION, WILL YOU?");
	//		}
	//		board = new Board(boardSize);
	//	}
	//	public Game Round(int player)
	//	{
	//		string color = (player == 1) ? "White" : "Black";
	//		bool flag = false;
	//		string input;
	//		int col=0, row=0;
	//		for(;;)
	//		{
	//			board.Print();
	//			Console.WriteLine($"Player {player}, is your turn to move. Remember that your color is {color}");
	//			while (!flag)
	//			{
	//				Console.WriteLine("Select pawn to move (Letter-Number format, please)");
	//				input = Console.ReadLine();
	//				if (input == "quit") Environment.Exit(0);
	//				col = input[0] - 'A';
	//				if (col < 0 || col >= board.size) continue;
	//				if (!int.TryParse(input.Substring(1), out row)) continue;
	//				if (board.field[col, row] != null)
	//				{
	//					if (board.field[col, row].color[0] == color[0]) flag = true;
	//					else Console.WriteLine("That's not your pawn! PAY ATTENTION! Again!");
	//				}
	//				else Console.WriteLine("You don't have a pawn there! Again!");
	//			}
	//			Pawn pawn = board.field[col, row];
	//			flag = false;
	//			while (!flag)
	//			{
	//				Console.WriteLine("Enter destination field (Letter-Number format, please)");
	//				input = Console.ReadLine();
	//				if (input == "quit") Environment.Exit(0);
	//				col = input[0] - 'A';
	//				if (col < 0 || col >= board.size) continue;
	//				if (!int.TryParse(input.Substring(1), out row)) continue;
	//				if (board.field[col, row]!=null)
	//				{
	//					Console.WriteLine("That field is ocupied! PAY ATTENTION! Again!");
	//					continue;
	//				}
	//			}
	//			if (!pawn.CanMoveTo( row,col, ref board)) Console.WriteLine("Invalid move. Check the rules and try again");
	//			else
	//			{
	//				MovePawn(pawn.Coordinates[0], pawn.Coordinates[1], col, row);
	//				Console.Clear();
	//				break;
	//			}
	//		}
	//		return this;
	//	}
	//	public void MovePawn(int currentCol, int currentRow, int moveCol, int moveRow)
	//	{
	//		Pawn pawn = board.field[currentCol, currentRow];
	//		board.field[currentCol, currentRow] = null;
	//		board.field[moveCol, moveRow] = pawn;
	//		if (moveCol - currentCol == 2)
	//		{
	//			if (moveRow - currentRow == 2) board.RemovePawn(currentCol + 1, currentRow + 1);
	//			else board.RemovePawn(currentCol + 1, currentRow - 1);
	//		}
	//		if (currentCol - moveCol == 2)
	//		{
	//			if (moveRow - currentRow == 2) board.RemovePawn(currentCol - 1, currentRow + 1);
	//			else board.RemovePawn(currentCol - 1, currentRow - 1);
	//		}
	//	}
	//	public int CheckForWin()
	//	{
	//		int countBlack = 0, countWhite = 0;
	//		bool canMove = false;
	//		for(int col=0;col<board.size;col++) for(int row = 0; row < board.size; row++)
	//			{
	//				Pawn pawn = board.field[col, row];
	//				if (pawn == null) continue;
	//				if (pawn.color == "W") countWhite++; else countBlack++;
	//				if (!canMove) canMove = pawn.CanMove(ref board);
	//			}
	//		if (countBlack != 0) return 2;
	//		if (countWhite != 0) return 1;
	//		if (!canMove) return -1;
	//		return 0;
	//	}
	//	public void AnnounceResult(int gameCode)
	//	{
	//		switch (gameCode)
	//		{
	//			case -1: { Console.WriteLine("Game is a draw. Better luck next time."); break; }
	//			case 1: { Console.WriteLine("Congratulation player 1, you won."); break; }
	//			case 2: { Console.WriteLine("Congratulation player 2, you won."); break; }
	//		}
	//	}
	////}
}
