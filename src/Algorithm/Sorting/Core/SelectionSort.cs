using Algorithm.Sorting.Common;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Sorting.Core
{
	internal class SelectionSort : Swapping, ISort
	{
		public void Sort<T>(IList<T> list, SortDirection typeSorting = SortDirection.Ascending) {
			Comparer<T> comparer = Comparer<T>.Default;
			int length = list.Count();

			for (int i = 0; i < length - 1; i++) {
				int minIndex = i;
				for (int index = i + 1; index < length; index++) { 
					if (typeSorting.Equals(SortDirection.Ascending))
						if (comparer.Compare(list[index], list[minIndex]) < 0)
							minIndex = index;

					if (typeSorting.Equals(SortDirection.Descending))
						if (comparer.Compare(list[index], list[minIndex]) > 0)
									minIndex = index;
				}

				Swap(list, minIndex, i);
			}
		}

		public void Sort<T>(T[] array, SortDirection typeSorting = SortDirection.Ascending) {
			Comparer<T> comparer = Comparer<T>.Default;
			int length = array.Count();

			for (int i = 0; i < length - 1; i++) {
				int minIndex = i;
				for (int index = i + 1; index < length; index++) { 
					if (typeSorting.Equals(SortDirection.Ascending))
						if (comparer.Compare(array[index], array[minIndex]) < 0)
							minIndex = index;

					if (typeSorting.Equals(SortDirection.Descending))
						if (comparer.Compare(array[index], array[minIndex]) < 0)
							minIndex = index;
				}

				Swap(array, minIndex, i);
			}
		}
	}
}
