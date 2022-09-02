using System;
using System.Linq;
using System.Collections.Generic;

namespace Text_Game
{
   public class Monster
   {
	  private int _hpMonster;

	  Fibber _fibber = new();

	  public Monster(int hpMonster)
	  {
		 _hpMonster = hpMonster;
	  }

	  public bool Injured()
	  {
		 var randomNumber = new Random().Next(1);

		 return randomNumber % 2 == 0;
	  }

	  public void Injury()
	  {
		 _fibber.Atack();

		 _hpMonster--;

		 Console.WriteLine($" У него осталось {_hpMonster} жизней");
	  }

	  public bool Fate()
	  {
		 return _hpMonster <= 0;
	  }

	  public void Loss()
	  {
		 _fibber.Defence();
	  }
   }
}