using System;
using System.Linq;
namespace LogicBubbleSort.NUnit.Tests
{
	public class SumIncrease : IComparer
	{
		public int Compare(int[] lhs, int[] rhs) => lhs.Sum() - rhs.Sum();
	}
}
