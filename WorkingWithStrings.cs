using System;

namespace WorkingWithStrings
{
	internal class WorkingWithStrings
	{
		static void Main(string[] args)
		{
			Console.Write("Как вас зовут? ");
			string name = Console.ReadLine();
			Console.Write("Сколько вам лет? ");
			string age = Console.ReadLine();
			Console.Write("Каков ваш знак зодиака? ");
			string zodiacSign = Console.ReadLine();
			Console.Write("Где вы работаете? ");
			string placeOfWork = Console.ReadLine();

			Console.WriteLine($"Вас зовут {name}, вам {age} год, вы {zodiacSign} и работаете {placeOfWork}");
		}
	}
}
