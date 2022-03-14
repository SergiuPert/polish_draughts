using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polish_Draughts
{
	class Pawn
	{
		public string color { get; set; }
		public int[,] Coordinates { get; set; }
		public bool IsCrowned;
		public Pawn(int x,int y,string c)
		{
		}
		public bool CanMoveTo(int x,int y, Board board)
		{
		}
		public bool CanMove(Board board)
		{
		}
	}
}
