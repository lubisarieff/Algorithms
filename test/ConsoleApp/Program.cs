using Algorithm.Sorting.Extentions;
using Algorithm.Sorting.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> number = new List<int>();
			List<int> bubleSort = new List<int>();

			Random random = new Random();
			
			for (int i = 0; i < 10000; i++)
				number.Add(random.Next(1, 10));

			bubleSort.AddRange(number);
			Thread.Sleep(100);

			Stopwatch timeBubbleSort = new Stopwatch();
			timeBubbleSort.Start();
			bubleSort.Sorting(SortingAlgorithms.SelectionSort, SortDirection.Descending);
			timeBubbleSort.Stop();
			bubleSort.ForEach(number => Console.Write($" {number}"));

			Console.WriteLine($"Time Bubble Sort : {timeBubbleSort.ElapsedMilliseconds} ms");

		}
	}
}
