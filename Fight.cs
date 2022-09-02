using System;
using System.Linq;
using System.Collections.Generic;

namespace Text_Game
{
   public class Fight
   {
	  int lifePoints = 0;
	  bool moriartiAlive = true;
	  int stepsToClear = 0;
	  private Moriarti _moriarti;
	  private Monster _monster;

	  public void Difficulty()
	  {
		 Console.WriteLine(" Выберите сложность: \n 1. Лёгкая \n 2. Средняя \n 3. Сложная \n Ваш выбор?");
		 while (true)
		 {
			var difficultyOutput = Console.ReadLine();

			if (difficultyOutput == "1")
			{
			   lifePoints = 15;

			   Console.WriteLine($" Впервые играешь? \n Колличество жизней: {lifePoints} \n  ");

			   break;
			}
			else if (difficultyOutput == "2")
			{
			   lifePoints = 10;

			   Console.WriteLine($" Классика! \n Колличество жизней: {lifePoints} \n  ");

			   break;
			}
			else if (difficultyOutput == "3")
			{
			   lifePoints = 5;

			   Console.WriteLine($" Смельчак. ت︎ \n Посмотрим на сколько тебя хватит... \n Колличество жизней: {lifePoints} \n  ");

			   break;
			}
			else
			{
			   Console.Clear();

			   Console.WriteLine(" Ошибка! \n Ответ неверный! \n Выберите снова.");

			   Console.WriteLine(" Выберите сложность: \n 1. Лёгкая \n 2. Средняя \n 3. Сложная \n Ваш выбор?");
			}
		 }
	  }

	  public void FightWithMonster()
	  {
		 _moriarti = new(lifePoints);
		 _monster = new(lifePoints);

		 while (true)
		 {
			if (_moriarti.Damaged())
			{
			   _moriarti.Damage();
			}

			else
			{
			   _moriarti.Miss();
			}

			if (_moriarti.Dead())
			{
			   moriartiAlive = false;
			   break;
			}

			stepsToClear += 1;

			if (_monster.Injured())
			{
			   _monster.Injury();
			}

			else
			{
			   _monster.Loss();
			}

			if (_monster.Fate())
			{
			   break;
			}

			if (stepsToClear == 5)
			{
			   stepsToClear = 0;

			   Console.Clear();
			}

			Console.WriteLine();
		 }
	  }

	  public bool CheckAlive()
	  {
		 return moriartiAlive;
	  }
   }
}