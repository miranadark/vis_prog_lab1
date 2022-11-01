using System;

namespace visual_programming_project
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] customers_1 = { 5, 3, 4 };
			int[] customers_2 = { 10, 2, 3, 3 };
			int[] customers_3 = { 2, 3, 10 };
			Console.WriteLine("Касса 1\tвермя\t" + HW1.QueueTime(customers_1, 1));
			Console.WriteLine("Касса 2\tвермя\t" + HW1.QueueTime(customers_2, 2));
			Console.WriteLine("Касса 3\tвермя\t" + HW1.QueueTime(customers_3, 2));
		}
	}
}
