using System;
using System.Linq;
using System.Collections.Generic;

namespace Text_Game
{
   public class Fibber
   {
	  private static Random randomNumber = new Random();

	  Dictionary<int, string> moriartiAtk = new Dictionary<int, string>()
	   {
		  {0, " Moriarti нанес урон игроку Monster"},
		  {1, " Moriarti отразил удар игрока Monster"}
	   };

	  Dictionary<int, string> monsterAtk = new Dictionary<int, string>()
		{
		  {0, " Monster нанес урон игроку Moriarti"},
		  {1, " Monster отразил удар игрока Moriarti"}
		};

	  Dictionary<int, string> moriartiDef = new Dictionary<int, string>()
	   {
		  {0, " Moriarti не попал по игроку Monster"},
		  {1, " Monster уклонился от удара игрока Moriarti"},
		  {2, " Monster пред-угодал удар игрока Monster и уклонился"}
	   };

	  Dictionary<int, string> monsterDef = new Dictionary<int, string>()
	   {
		  {0, " Monster не попал по игроку Moriarti"},
		  {1, " Moriarti уклонился от удара игрока Monster"},
		  {2, " Moriarti пред-угодал удар игрока Monster и уклонился"}
	   };

	  Dictionary<int, string> moriartiDeath = new Dictionary<int, string>()
	  {
		  {1, "\n Monster подходит к вам... \n Пинает и уходит \n Вы не отреагировали т.к. были мертвы \n Game Over! \n Press F"},
		  {0, "\n По итогу монстр оказался сильнее. \n Чем вы расчитывали... \n Game Over! \n Press F"}
	  }; 
	  
	  public void Atack()
	  {
		 Console.WriteLine(moriartiAtk[randomNumber.Next(2)]);
	  }

	  public void Defence()
	  {
		 Console.WriteLine(moriartiDef[randomNumber.Next(3)]);
	  }

	  public void Charge()
	  {
		 Console.WriteLine(monsterAtk[randomNumber.Next(2)]);
	  }

	  public void Protection()
	  {
		 Console.WriteLine(monsterDef[randomNumber.Next(3)]);
	  }

	  public void IsDead()
	  {
		 Console.WriteLine(moriartiDeath[randomNumber.Next(2)]);
	  }
   }
}