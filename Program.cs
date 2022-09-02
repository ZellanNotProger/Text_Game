using System;

namespace Text_Game
{
   public static class Program
   {
	  public static void Main()
	  {
		 var _game = new Game();
		 var _fight = new Fight();

		 _game.Start();

		 _fight.Difficulty();

		 _game.PlayChapter1();

		 _fight.FightWithMonster();

		 if (_fight.CheckAlive())
		 {
			_game.PlayChapter2();

			_fight.FightWithMonster();

			if (_fight.CheckAlive())
			{
           _game.PlayChapter3();
			}

			else
			{
			   _game.Ending();
			}
		 }
		 else
		 {
			_game.Ending();
		 }
	  }
   }
}