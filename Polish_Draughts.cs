using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polish_Draughts
{
	public class Game
	{
		Board board;
		static void Main(string[] args)
		{
			Board board = new Board(10);
			string boardData = board.ToString();
			board.GetBoardSign(boardData);
			board.PrintBoard();
			Console.ReadLine();
			
		}
		public void Start()
		{
		}
		public void Round(string player)
		{
		}
		public bool MovePawn(int x1, int y1, int x2, int y2)
		{
			throw new NotImplementedException();
		}
		public int CheckForWin()
		{
			throw new NotImplementedException();
		}
	}
}
