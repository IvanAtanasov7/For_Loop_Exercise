using System;

namespace _07._Trekking_Mania
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int count = 0;

			int num;

			double countP1 = 0;
			double countP2 = 0;
			double countP3 = 0;
			double countP4 = 0;
			double countP5 = 0;


			for (int i = 1; i <= n; i++)
			{
				num = int.Parse(Console.ReadLine());
				count += num;

				if (num <= 5)
				{
					countP1 += num;
				}
				else if (num <= 12)
				{
					countP2 += num;
				}
				else if (num <= 25)
				{
					countP3 += num;
				}
				else if (num <= 40)
				{
					countP4 += num;
				}
				else
				{
					countP5 += num;
				}
			}

			double p1 = countP1 / count * 100;
			double p2 = countP2 / count * 100;
			double p3 = countP3 / count * 100;
			double p4 = countP4 / count * 100;
			double p5 = countP5 / count * 100;

			Console.WriteLine($"{p1:F2}%");
			Console.WriteLine($"{p2:F2}%");
			Console.WriteLine($"{p3:F2}%");
			Console.WriteLine($"{p4:F2}%");
			Console.WriteLine($"{p5:F2}%");
		}
	}
}
