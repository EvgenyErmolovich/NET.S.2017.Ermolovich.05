using System.Linq;
using System.Collections.Generic;
namespace LogicBubbleSort.NUnit.Tests
{
	public class MinElementDecrease : IComparer<int[]>
	{
		public int Compare(int[] lhs, int[] rhs) => rhs.Min() - lhs.Min();
	}
}
