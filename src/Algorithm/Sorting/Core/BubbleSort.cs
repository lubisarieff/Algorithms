using Algorithm.Sorting.Common;
using System.Collections.Generic;

namespace Algorithm.Sorting.Core
{
	internal class BubbleSort : Swapping, ISort
	{
		public void Sort<T>(IList<T> list, SortDirection typeSorting) {
			Comparer<T> comparer = Comparer<T>.Default;
			int length = list.Count - 1;
			bool isSwap = false;
			
			for (int i = 0; i < length; i++) {
				isSwap = false;

				for (int index = 0; index < length - i; index++) {
					if (typeSorting.Equals(SortDirection.Ascending))
						if (comparer.Compare(list[index], list[index + 1]) > 0) { 
							Swap(list, index, index + 1);
							isSwap = true;
						}

					if (typeSorting.Equals(SortDirection.Descending))
						if (comparer.Compare(list[index], list[index + 1]) < 0) { 
							Swap(list, index, index + 1);
							isSwap = true;
						}
				}

				if (!isSwap)
					break;
			}
		}
	

		public void Sort<T>(T[] array, SortDirection typeSorting) {
			Comparer<T> comparer = Comparer<T>.Default;
			int length = array.Length - 1;

			for (int i = 0; i < length; i++)
				for (int index = 0; index < length - i; index++) {
					if (typeSorting.Equals(SortDirection.Ascending))
						if (comparer.Compare(array[index], array[index + 1]) > 0)
							Swap(array, index, index + 1);

					if (typeSorting.Equals(SortDirection.Descending))
						if (comparer.Compare(array[index], array[index + 1]) < 0)
							Swap(array, index, index + 1);
				}
		}
	}
}
