using System;

namespace _08._Tennis_Ranklist
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int countOfTournaments = int.Parse(Console.ReadLine());
			int startingPoints = int.Parse(Console.ReadLine());

			int tournamentPoints = 0;
			int wonTournaments = 0;

			for (int i = 1; i <= countOfTournaments; i++)
			{
				string text = Console.ReadLine();

				switch (text)
				{
					case "W": tournamentPoints += 2000; wonTournaments++; break;
					case "F": tournamentPoints += 1200; break;
					case "SF": tournamentPoints += 720; break;
				}
			}
			double finalPoints = startingPoints + tournamentPoints;
			double averagePoints = tournamentPoints * 1.0 / countOfTournaments;
			double percent = wonTournaments * 1.0 / countOfTournaments * 100;
			Console.WriteLine($"Final points: {finalPoints}");
			Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
			Console.WriteLine($"{percent:F2}%");
		}
	}
}
