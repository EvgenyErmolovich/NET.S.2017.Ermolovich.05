using System.Collections.Generic;
using System.Linq;
namespace LogicBubbleSort.NUnit.Tests
{
	public class MaxElementDecrease : IComparer<int[]>
	{
		public int Compare(int[] lhs, int[] rhs) => rhs.Max() - lhs.Max();
	}
}
