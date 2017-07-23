using System.Linq;
using System.Collections.Generic;
namespace LogicBubbleSort.NUnit.Tests
{
	public class SumDecrease : IComparer<int[]>
	{
		public int Compare(int[] lhs, int[] rhs) => rhs.Sum() - lhs.Sum();
	}
}
