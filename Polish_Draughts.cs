using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polish_Draughts
{
	class Program
	{
		static void Main(string[] args)
		{
			Game game=new Game;
			for(;;)
			{
				int endGame = 0;
				Console.WriteLine("Welcome to Polish Draughts");
				Console.WriteLine("This is a two players game, black and white, hat take turns moving their pieces");
				Console.WriteLine("Pieces may be moved one square diagonaly if the destination square is free,");
				Console.WriteLine("or jumped over another piece diagonaly if the square behind is free");
				Console.WriteLine("If you jump over your oponet's piece, it is captured - removed from the game.");
				Console.WriteLine("Plyers alternate and white starts");
				Console.WriteLine("The aim is to capture more oponent pieces than you loose and move your surviving pieces to the othr side of the board");
				game.Start();
				for(int player = 1;endGame == 0; player=(player+1)%2){ 
					game.Round(player);
					endGame = game.CheckForWin();
					}
				switch (endGame)
				{
					case -1: { Console.WriteLine("Game is a draw. Better luck next time.");break; }
					case 1: { Console.WriteLine("Congratulation player 1, you won."); break; }
					case 2: { Console.WriteLine("Congratulation player 2, you won."); break; }
				}
				Console.WriteLine("Game Over. Do you wish to quit?");
				if (Console.ReadLine() == "yes") Environment.Exit(0);
			}
		}
	}
}
