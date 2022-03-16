using System;

namespace Polish_Draughts
{
	public class Board
	{
		private int _size;
		public Pawn[,] field { get; set; }
		
		public Board(int size)
		{
			_size = size;
			field = new Pawn[size, size];
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

			for (int i = size-1 ; i >=0 ; i--)
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
			
			for(int i = 0; i < _size; i++)
			{
				for (int j = 0; j < _size; j++)
                {
					Console.Write(string.IsNullOrEmpty(field[i, j].color)? " ": field[i, j].color);
				}
				Console.WriteLine();
			}
			

		}
        public override string ToString()
        {
			PrintBoard();
            return base.ToString();
        }

        public void RemovePawn(int x,int y)
		{
			throw new NotImplementedException();
		}
		public void MovePawn(int x1,int y1,int x2,int y2)
		{
			throw new NotImplementedException();
		}
	}
}
