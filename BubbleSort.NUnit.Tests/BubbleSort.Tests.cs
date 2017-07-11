using NUnit.Framework;
using System;
namespace LogicBubbleSort.NUnit.Tests
{
	[TestFixture()]
	public class BubbleSortTests
	{
		/*[TestCase(new int[] { 1, 3, 4, 5 }, new int[] { 2, 3 }, new int[] { 1, 1, 4 },
		          ExpectedResult = new int[][] { new int[]{ 2, 3 }, new int[]{ 1, 1, 4 }, new int[]{ 1, 3, 4, 5 } })]
		public int[][] Sort_PositiveTests(params int[][] array)
		{
			BubbleSort.Sort(array);
			return array;
		}*/

		[TestCase(new int[] { 1, 3, 4, 5 }, null, new int[] { 1, 1, 4 })]
		public static void Sort_ThrowsArgumentNullException(params int[][] array)
		{
			Assert.Throws<ArgumentNullException>(() => BubbleSort.Sort(array));
		}
	}
}
