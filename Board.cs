using System;

namespace Polish_Draughts
{
	class Board
	{
		public int size { get; set; }
		public Pawn[,] field { get; set; }
		public Board(int n)
		{
		}
		public void Print()
		{
		}
		public bool RemovePawn(int x,int y)
		{
			return true;
		}
		public bool MovePawn(int x1,int y1,int x2,int y2)
		{
			return true;
		}
	}
}
