using NUnit.Framework;
using System;
using System.Linq;
namespace LogicBubbleSort.NUnit.Tests
{
	[TestFixture()]
	public class BubbleSortTests
	{
		[TestCase(new int[] { 1, 3, 4, 5 }, new int[] { 1, 2 }, new int[] { 1, 1, 4 }, ExpectedResult = true)]
		public bool Sort_PositiveTests(params int[][] array)
		{
			bool ans = true;
			BubbleSort.Sort(array, new SumIncrease());
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i].Sum() > array[i + 1].Sum()) ans = false;
			}

			BubbleSort.Sort(array, new SumDecrease());
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i].Sum() < array[i + 1].Sum()) ans = false;
			}

			BubbleSort.Sort(array, new MinElementIncrease());
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i].Min() > array[i + 1].Min()) ans = false;
			}

			BubbleSort.Sort(array, new MinElementDecrease());
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i].Min() < array[i + 1].Min()) ans = false;
			}

			BubbleSort.Sort(array, new MaxElementIncrease());
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i].Max() > array[i + 1].Max()) ans = false;
			}

			BubbleSort.Sort(array, new MaxElementDecrease());
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i].Max() < array[i + 1].Max()) ans = false;
			}

			return ans;
		}

		[TestCase(new int[] { 1, 3, 4, 5 }, null, new int[] { 1, 1, 4 })]
		public static void Sort_ThrowsArgumentNullException_Sum(params int[][] array)
		{
			Assert.Throws<ArgumentNullException>(() => BubbleSort.Sort(array, new SumIncrease()));
		}

		[TestCase(new int[] { 1, 3, 4, 5 }, null, new int[] { 1, 1, 4 })]
		public static void Sort_ThrowsArgumentNullException_Max(params int[][] array)
		{
			Assert.Throws<ArgumentNullException>(() => BubbleSort.Sort(array, new MaxElementIncrease()));
		}

		[TestCase(new int[] { 1, 3, 4, 5 }, null, new int[] { 1, 1, 4 })]
		public static void Sort_ThrowsArgumentNullException_Min(params int[][] array)
		{
			Assert.Throws<ArgumentNullException>(() => BubbleSort.Sort(array, new MinElementIncrease()));
		}
	}
}
