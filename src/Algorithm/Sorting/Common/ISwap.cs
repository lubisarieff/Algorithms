using System.Collections.Generic;

namespace Algorithm.Sorting.Common
{
	internal interface ISwap {
		void Swap<T>(IList<T> list, int firstIndex, int secondIndex);
		void Swap<T>(T[] array, int firstIndex, int secondIndex);
	}
}
