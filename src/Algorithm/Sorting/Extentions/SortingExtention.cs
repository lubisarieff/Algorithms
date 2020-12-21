using Algorithm.Sorting.Common;
using Algorithm.Sorting.Core;
using System;
using System.Collections.Generic;

namespace Algorithm.Sorting.Extentions
{
	public static class SortingExtention
	{
		private static IDictionary<SortingAlgorithms, Func<ISort>> TypeSortingAlgorithms = new Dictionary<SortingAlgorithms, Func<ISort>>() {
			{ SortingAlgorithms.BubbleSort, () => new BubbleSort()},
			{ SortingAlgorithms.SelectionSort, () => new SelectionSort()}
		};

		public static void Sorting<T>(this IList<T> list, SortingAlgorithms sortingAlgorithms = SortingAlgorithms.BubbleSort, SortDirection typeSorting = SortDirection.Ascending) {
			TypeSortingAlgorithms[sortingAlgorithms]().Sort(list, typeSorting);
		}

		public static void Sorting<T>(this T[] array, SortingAlgorithms sortingAlgorithms = SortingAlgorithms.BubbleSort, SortDirection typeSorting = SortDirection.Ascending) {
			TypeSortingAlgorithms[sortingAlgorithms]().Sort(array, typeSorting);
		}
	}
}
