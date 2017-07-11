using System;
namespace LogicBubbleSort
{
	public static class BubbleSort
	{
		delegate int Compare (int[] a, int[] b);
		/// <summary>
		/// Sort the specified arr.
		/// </summary>
		/// <returns>The sort.</returns>
		/// <param name="arr">Arr.</param>
		public static void Sort(int[][] arr)
		{
			ValidInput(arr);
			Compare compare = BySumOfElements;
			for (int k = arr.Length - 1; k > 0; k--)
				for (int i = 0; i < k; i++)
					if (compare(arr[i],arr[i+1]) > 0) Swap(ref arr[i], ref arr[i + 1]);
		}

		/// <summary>
		/// The sum of elements.
		/// </summary>
		/// <returns>The sum of elements.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		private static int BySumOfElements(int[] a, int[] b) => SumOfArray(a) - SumOfArray(b);

		/// <summary>
		/// The max element.
		/// </summary>
		/// <returns>The max element.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		private static int ByMaxElement(int[] a, int[] b) => MaxElement(a) - MaxElement(b);

		/// <summary>
		/// The minimum element.
		/// </summary>
		/// <returns>The minimum element.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		private static int ByMinElement(int[] a, int[] b) => MinElement(a) - MinElement(b);

		/// <summary>
		/// Minimums the element.
		/// </summary>
		/// <returns>The element.</returns>
		/// <param name="a">The alpha component.</param>
		private static int MinElement(int[] a)
		{
			int min = a[0];
			for (int i = 0; i < a.Length; i++)
				if (a[i] < min) min = a[i];
			return min;
		}

		/// <summary>
		/// Maxs the element.
		/// </summary>
		/// <returns>The element.</returns>
		/// <param name="a">The alpha component.</param>
		private static int MaxElement(int[] a)
		{
			int max = a[0];
			for (int i = 0; i < a.Length; i++)
				if (a[i] > max) max = a[i];
			return max;
		}

		/// <summary>
		/// Sums the of array.
		/// </summary>
		/// <returns>The sum of array.</returns>
		/// <param name="a">The alpha component.</param>
		private static int SumOfArray(int[] a)
		{
			int sum = 0;
			for (int i = 0; i < a.Length; i++)
				sum += a[i];
			return sum;
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
