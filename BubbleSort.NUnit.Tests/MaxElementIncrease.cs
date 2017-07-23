using System.Linq;
using System.Collections.Generic;
namespace LogicBubbleSort.NUnit.Tests
{
	public class MaxElementIncrease : IComparer<int[]>
	{
		public int Compare(int[] lhs, int[] rhs) => lhs.Max() - rhs.Max();
	}
}
