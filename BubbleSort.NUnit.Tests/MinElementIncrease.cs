using System.Linq;
using System.Collections.Generic;
namespace LogicBubbleSort.NUnit.Tests
{
	public class MinElementIncrease : IComparer<int[]>
	{
		public int Compare(int[] lhs, int[] rhs) => lhs.Min() - rhs.Min();
	}
}
