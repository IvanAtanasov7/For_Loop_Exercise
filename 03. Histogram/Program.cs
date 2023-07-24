using System;

namespace _03._Histogram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int num;

			double countP1 = 0;
			double countP2 = 0;
			double countP3 = 0;
			double countP4 = 0;
			double countP5 = 0;

			for (int i = 1; i <= n; i++)
			{
				num = int.Parse(Console.ReadLine());

				if (num < 200)
				{
					countP1++;
				}
				else if (num >= 200 && num <= 399)
				{
					countP2++;
				}
				else if (num >= 400 && num <= 599)
				{
					countP3++;
				}
				else if (num >= 600 && num <= 799)
				{
					countP4++;
				}
				else
				{
					countP5++;
				}
			}

			double p1 = countP1 / n * 100;
			double p2 = countP2 / n * 100;
			double p3 = countP3 / n * 100;
			double p4 = countP4 / n * 100;
			double p5 = countP5 / n * 100;

			Console.WriteLine($"{p1:F2}%");
			Console.WriteLine($"{p2:F2}%");
			Console.WriteLine($"{p3:F2}%");
			Console.WriteLine($"{p4:F2}%");
			Console.WriteLine($"{p5:F2}%");

		}
	}
}

