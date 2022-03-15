using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polish_Draughts
{
	class Board
	{
		private int size;
		public Pawn[,] field { get; set; }
		public Board(int n)
		{
		}
		public void Draw()
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
