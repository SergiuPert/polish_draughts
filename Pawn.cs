using System;

namespace Polish_Draughts
{
	class Pawn
	{
		public string color { get; set; }
		public int[] Coordinates { get; set; }
		public bool IsCrowned;
		public Pawn(int x,int y,string c)
		{
		}
		public bool CanMoveTo(int x,int y,ref Board board)
		{
		}
		public bool CanMove(ref Board board)
		{
		}
	}
}
