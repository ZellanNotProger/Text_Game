using System;
using System.Linq;
using System.Collections.Generic;

namespace Text_Game
{
   public class Moriarti
   {
	  private int _hpMoriarti;

	  Fibber _fibber = new();

	  public Moriarti(int hpMoriarti)
	  {
		 _hpMoriarti = hpMoriarti;
	  }

	  public bool Damaged()
	  {
		 var randomNumber = new Random().Next(2);

		 return randomNumber % 2 == 0;
	  }

	  public void Damage()
	  {
		 _fibber.Charge();

		 _hpMoriarti--;

		 Console.WriteLine($" У вас осталось {_hpMoriarti} жизней");
	  }

	  public bool Dead()
	  {
		 return _hpMoriarti <= 0;
	  }

	  public void Miss()
	  {
		 _fibber.Protection();
	  }
   }
}