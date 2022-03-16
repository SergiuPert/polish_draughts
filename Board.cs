using System;

namespace Polish_Draughts
{
	public class Board
	{
		public int size { get; set; }
		public Pawn[,] field { get; set; }
		
		public Board(int Size)
		{
			size = Size;
			field = new Pawn[size, size];
			//for (int col = 0; col < size; col++) {
			//	field[col, col % 2] = new Pawn(col, col % 2, "W");
			//	field[col, col % 2 + size - 2] = new Pawn(col, col % 2 + size - 2, "B");
			//}
			int whitePawns = size;
			int blackPawns = size;
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (IsBlack(i, j) && whitePawns > 0)
					{
						field[i, j] = new Pawn(i, j, "W");
						whitePawns--;
					}
				}
			}

			for (int i = size - 1; i >= 0; i--)
			{
				for (int j = 0; j < size; j++)
				{
					if (IsBlack(i, j) && blackPawns > 0)
					{
						field[i, j] = new Pawn(i, j, "B");
						blackPawns--;
					}
				}
			}
		}

		
		public bool IsBlack(int x, int y)
		{
			if (x % 2 == 0)
				if (y % 2 == 0)
					return true;
			if (x%2 == 1)
				if (y%2 == 1)
					return true;
			return false;
		}
		public void PrintBoard()
		{
			string s = "   ";
			for (int col = 0; col< size; col++) s += $" {(char)('A' + col)} ";
			Console.WriteLine(s);

			for(int col = 0; col < size; col++)
			{
				Console.Write($"{col}");
				if (col < 10) Console.Write("  ");
				for (int row = 0; row < size; row++)
                {
					Console.Write(" ");
					Console.Write((field[col, row]==null)? " ": field[col, row].color);
					Console.Write(" ");
				}
				Console.WriteLine();
			}
			

		}
        public override string ToString()
        {
			PrintBoard();
            return base.ToString();
        }

        public void RemovePawn(int col,int row)
		{
			field[col, row] = null;
		}
		public void MovePawn(int col1,int row1,int col2,int row2)
		{
			Pawn pawn = field[col1, row1];
			pawn.Coordinates[1] = row2;
			pawn.Coordinates[0] = col2;
			field[col1, row1] = null;
			field[col2, row2] = pawn;
		}
	}
}
