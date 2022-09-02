using System;

namespace Text_Game
{
   public static class Program
   {
	  public static void Main()
	  {
		 var game = new Game();
		 var fight = new Fight();

		 game.Start();

		 fight.Difficulty();

		 game.PlayChapter1();

		 fight.FightWithMonster();

		 if (fight.CheckAlive())
		 {
			game.PlayChapter2();

			fight.FightWithMonster();

			if (fight.CheckAlive())
			{
           game.PlayChapter3();
			}

			else
			{
			   game.Ending();
			}
		 }
		 else
		 {
			game.Ending();
		 }
	  }
   }
}