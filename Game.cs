using System;
using System.Linq;
using System.Collections.Generic;

namespace Text_Game
{
   public class Game
   {
	  Fibber _fibber = new();

	  public void Start()
	  {
		 Console.WriteLine(" Хотите начать игру?");

		 string startGame = (Console.ReadLine()).ToLower();

		 if (startGame == "yes")
		 {
			Console.WriteLine(" Игра началась. Желаю удачи ت︎ \n  ");
		 }

		 else
		 {
			Console.WriteLine(" Мне без разницы. Игра началась ☠︎︎ \n  ");
		 }
	  }

	  public void PlayChapter1()
	  {
		 Console.WriteLine(" Вас засосало во временную воронку.\n Вы попали в конец XVI века в городок Сейлем.\n Вас заподозрили в колдовстве, но доказательств было мало.\n Суд предложил вам пройти испытание, чтобы доказать, что вы не злобный колдун.\n Вы согласились, и вас отправили в катакомбы. \n  \n Вы решили прогуляться по катакомбам с целью изучить их получше. \n В катакомбах было ужасное освещение. \n Вы исследовали катакомбы около часа и узнали: \n 1. Потолки были весьма невысокими (приблизительно 1,8м) \n 2. Все корридоры и проходы были широкими (около 3х больших шагов) \n 3. Часто встречались деревянные двери, словно ведущие в дополнительные комнаты. \n 4. Стены из песчаника этих катакомб, всьма не редко стены были в трещеннах \n  \n И вот вы проходите мимо очередного угла и вдруг... \n На вас нападает монстр! \n Шансы на побег не велки. \n Попробуете сбежать? \n 1. Yes \n 2. No \n Ваш выбор?");

		 bool kickedTheMonster = (Console.ReadLine()).ToLower() == "yes";

		 Console.Clear();

		 var monsterFightOutput = kickedTheMonster ? "Сбежать не удалось \n Монстр увидел вас, и напал на вас \n Вы сражаетесь с монстром... \n  " : " Вы сделали смелый ход и напали на монстра \n Вы сражаетесь с монстром... \n  ";

		 Console.WriteLine(monsterFightOutput);
	  }

	  public void PlayChapter2()
	  {
		 Console.WriteLine(" \n По итогам схватки, вы оказались победителем. \n После драки с монстром, вы решили передохнуть. \n Вы легли у ближайшего угла \n Лежа около угда стены, вы вспомнили, что у вас есть телефон с собой. \n Поиграть в него или уснуть, пока вы лежите? \n 1. Yes \n 2. No \n Ваш выбор?");

		 bool playInPhone = (Console.ReadLine()).ToLower() == "yes";

		 Console.Clear();

		 var timeRelaxOutput = playInPhone ? " Вы играете в телефон \n Телефон сел и вы отдохнули. \n После отдыха, вы прожолжаете свой путь по катакомбам. \n  " : " Вы удачно выспались \n Телефон к счастью с полной батареей \n Отдохнув вы продолжаете свлй путь \n  ";

		 Console.WriteLine($"{timeRelaxOutput} \n Вы идете мимо очередного прохода и видите закрытую дверь \n Хотите ее открыть? \n 1. Yes \n 2. No \n Ваш выбор?");

		 bool enteredTheDoor = (Console.ReadLine()).ToLower() == "yes";

		 if (enteredTheDoor)
		 {
			Console.WriteLine(" Вы попробовали открыть дверь \n Дверь отперлась от ваших толчков \n За этой дверью стоял темный силуэт \n  ");

			var unknownPersonOutput = playInPhone ? " Так как ваш телефон сел, вы не смогли понять кто это. \n Вы решили задать несколько вопросов на небольшом расстоянии: \n Кто ты? Что ты здесь делаешь? И подобные, для того чтобы понять, кто это \n Оказалось это был человек женского пола \n  " : " У вас был с собой телефон \n Вы подошли поближе и узнали, что это был человек женского пола \n  ";

			Console.WriteLine(unknownPersonOutput);
		 }

		 else
		 {
			Console.WriteLine(" Вы собрались уходить, но вдруг дверь распохнулась... \n Посмотрите, что за этой дверью? \n 1. Yes \n 1. No \n Ваш выбор?");

			bool darkSilhouette = (Console.ReadLine()).ToLower() == "yes";

			if (darkSilhouette && !playInPhone)
			{
			   Console.WriteLine(" Вы собирались уйти, но вдруг... \n Из этой двери выходит темный силуэт \n Но так, как у вас был с собой телефон с фонариком \n Вы смогли подойти поближе и узнать, что это был человек женского пола \n  ");
			}

			else
			{
			   Console.WriteLine(" Вы собирались уйти, но вдруг... \n Из этой двери выходит темный силуэт \n Так как телефон сел, вы не смогли понять кто это. \n Вы решили задать несколько вопросов на небольшом расстоянии: \n Кто ты? Что ты здесь делаешь? И подобные, для того чтобы понять, кто это \n Оказалось это был человек женского пола");
			}
		 }
		 Console.WriteLine(" \n Она предложила познакомиться и представилась, как Айдай \n Хотите сказать свое имя в ответ? \n 1. Yes \n 2. No \n Ваш выбор?");

		 bool introduceYourself = (Console.ReadLine()).ToLower() == "yes";

		 Console.Clear();

		 var introduceYourselfOutput = introduceYourself ? " Вы вежливо в ответ представились, как Мориарти \n  " : " Вы не стали представляться. \n  ";

		 Console.WriteLine($"\n{introduceYourselfOutput} \n Теперь вы стали изучать катакомбы вместе \n   \n Итак... \n Вы блуждаете вместе уже минут 15 и встретили развилку \n Разделиться для более быстрого изучения? \n 1. Yes \n 2. No \n Ваш выбор?");

		 bool splitUp = (Console.ReadLine()).ToLower() == "yes";

		 var splitUpOutput = splitUp ? " Вы предложили ей разделиться, чтобы быстрее исследовать катакомбы \n Она была значительно против \n Она грозно возразила, что идти вы будете вместе" : " Вы вместе пошли направо, ведь, как известно, право и есть правельно";

		 Console.WriteLine($" \n{splitUpOutput} \n  \n После не долгих блужданий вы наткнулись на лестницу \n Из нее начал выходить монстр \n Попытаетесь спрятаться у другого конца лестницы? \n Ваш выбор? \n 1. Yes \n 2. No \n Ваш выбор?");

		 bool shelter = (Console.ReadLine()).ToLower() == "yes";

		 var shelterOutput = shelter ? " Вы попытались спрятаться у другого конца лестницы \n Но вдруг Айдай споткнулась об трещену \n Монстр среагировал и напал на вас. \n Вы сражаетесь с монстром в одиночку \n  " : " Вы на прямую напали на монстра \n Вы сражаетесь с ним в одиночку \n  ";

		 Console.WriteLine(shelterOutput);

		 Console.ReadKey();
	  }

	  public void PlayChapter3()
	  {
		 Console.Clear();

		 Console.WriteLine("\n  \n И вот очередная победа над монстром. \n Айдай предложила вам спуститься по этой лестнице \n Согласитесь с ней? \n 1. Yes \n 2. No \n Ваш выбор?");

		 bool descend = (Console.ReadLine()).ToLower() == "yes";

		 var descendOutput = descend ? " Вы вместе спустились вниз" : " Она хватает вас за руку и тащит вниз по лестнице";
	  
	  	Console.WriteLine(descendOutput);
	  }

	  public void Ending()
	  {
		 _fibber.IsDead();

		 var guessedRight = (Console.ReadLine()).ToLower() == "f";

		 var gussedReightOutput = guessedRight ? " Молодец! \n Отличная была игра!" : " Не плохо вышло \n Повезет и в следующий раз!";

		 Console.WriteLine(gussedReightOutput);

		 Console.WriteLine("\n  \n В создании игры участвовали: \n { \n Программисты: \n Ramis, \n ZellanNotProger; \n  \n Сценаристы: \n Ramis, \n NoLyrics, \n TobiLal; \n  \n Тестировщики: \n Black Boom, \n GG_Gerta; \n   \n Спонсоры: \n Black Boom, \n Ctanislavskiy, \n GG_Gerta; \n }");
	  }
   }
}