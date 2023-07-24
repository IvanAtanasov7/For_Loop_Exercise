using System;

namespace _04._Clever_Lily
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int age = int.Parse(Console.ReadLine());
			double priceWashingMachine = double.Parse(Console.ReadLine());
			int toyPrice = int.Parse(Console.ReadLine());

			int money = 0;

			for (int birthday = 1; birthday <= age; birthday++)
			{
				if (birthday % 2 == 0)
				{
					money += birthday * 5 - 1;

				}
				else
				{
					money += toyPrice;
				}
			}

			if (money >= priceWashingMachine)
			{
				double leftMoney = money - priceWashingMachine;
				Console.WriteLine($"Yes! {leftMoney:F2}");
			}
			else
			{
				double needMoney = priceWashingMachine - money;
				Console.WriteLine($"No! {needMoney:F2}");
			}
		}
	}
}
