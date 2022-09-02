using System;
using System.Linq;
using System.Collections.Generic;

namespace Text_Game
{
   public class Fibber
   {
	  private static Random randomNumber = new Random();

	  string moriartiAtk = new string() {" Moriarti нанес урон игроку Monster", " Moriarti отразил удар игрока Monster"};

	  string monsterAtk = new string() {" Monster нанес урон игроку Moriarti", " Monster отразил удар игрока Moriarti"};
	  
	  string moriartiDef = new string() {" Moriarti не попал по игроку Monster", " Monster уклонился от удара игрока Moriarti", " Monster предугадал удар игрока Monster и уклонился"};

	  string monsterDef = new string() {" Monster не попал по игроку Moriarti", " Moriarti уклонился от удара игрока Monster", " Moriarti предугадал удар игрока Monster и уклонился"};

	  string moriartiDeath = new string() {"\n Monster подходит к вам... \n Пинает и уходит \n Вы не отреагировали т.к. были мертвы \n Game Over! \n Press F", "\n По итогу монстр оказался сильнее. \n Чем вы расчитывали... \n Game Over! \n Press F"};

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