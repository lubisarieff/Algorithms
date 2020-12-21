using System.Collections.Generic;

namespace Algorithm.Sorting.Common
{
	internal abstract class Swapping : ISwap
	{
		public virtual void Swap<T>(IList<T> list, int firstIndex, int secondIndex)
		{
			T temp = list[firstIndex];
			list[firstIndex] = list[secondIndex];
			list[secondIndex] = temp;
		}

		public virtual void Swap<T>(T[] array, int firstIndex, int secondIndex)
		{
			T temp = array[firstIndex];
			array[firstIndex] = array[secondIndex];
			array[secondIndex] = temp;
		}
	}
}
