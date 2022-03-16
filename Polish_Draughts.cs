using System;

namespace Polish_Draughts
{
	class Program
	{
		static void Main(string[] args)
		{
			Game game=new Game();
			for(;;)
			{
				int endGame = 0;
				int player = 1;
				game.presentation().Start();
				while (endGame==0) {
					game.Round(player);
					endGame = game.CheckForWin();
					player = (player + 1) % 2;
				}
				game.AnnounceResult(endGame);
				Console.WriteLine("Game Over. Do you wish to quit?");
				if (Console.ReadLine() == "yes") Environment.Exit(0);
			}
		}
	}
}
