using System.Collections.Generic;

namespace Algorithm.Sorting.Common
{
	internal interface ISort {
		void Sort<T>(IList<T> list, SortDirection typeSorting);
		void Sort<T>(T[] array, SortDirection typeSorting);
	}
}
