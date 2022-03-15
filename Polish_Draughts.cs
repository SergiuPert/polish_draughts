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
				game.presentation().Start();
				game.;
				for(int player = 1;endGame == 0; player=(player+1)%2) endGame = game.Round(player).CheckForWin();
				game.AnnounceResult(endGame);
				Console.WriteLine("Game Over. Do you wish to quit?");
				if (Console.ReadLine() == "yes") Environment.Exit(0);
			}
		}
	}
}
