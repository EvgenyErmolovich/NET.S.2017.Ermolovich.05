using System;
using System.Collections.Generic;
namespace LogicBubbleSort
{
	public static class BubbleSort
	{
		/// <summary>
		/// Sort the specified arr.
		/// </summary>
		/// <returns>The sort.</returns>
		/// <param name="arr">Arr.</param>
		public static void Sort(int[][] arr, IComparer<int[]> comparer)
		{
			BSort(arr, comparer.Compare);
		}
		private static void BSort(int[][] arr, Comparison<int[]> comparision)
		{
            ValidInput(arr);
			for (int i = 0; i < arr.Length; i++)
				for (int j = 0; j < arr.Length - 1; j++)
					if (comparision(arr[j], arr[j + 1]) > 0)
						Swap(ref arr[j], ref arr[j + 1]); 
		}
		/// <summary>
		/// Swap the specified a and b.
		/// </summary>
		/// <returns>The swap.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		private static void Swap(ref int[] a, ref int[] b)
		{
			int[] temp = a;
			a = b;
			b = temp;
		}

		/// <summary>
		/// Valids the input.
		/// </summary>
		/// <param name="a">The array.</param>
		private static void ValidInput(int[][] a)
		{
			for (int i = 0; i < a.Length; i++)
				CheckArray(a[i]);
		}

		/// <summary>
		/// Checks the array.
		/// </summary>
		/// <param name="a">The array.</param>
		private static void CheckArray(int[] a)
		{
			if (a == null) throw new ArgumentNullException("Error!");
			if (a.Length == 0) throw new ArgumentException("Array is empty!");
		}
	}
}
