using System.Linq;
using System.Collections.Generic;
namespace LogicBubbleSort.NUnit.Tests
{
	public class SumIncrease : IComparer<int[]>
	{
		public int Compare(int[] lhs, int[] rhs) => lhs.Sum() - rhs.Sum();
	}
}
