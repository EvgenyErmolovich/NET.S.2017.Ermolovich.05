using System;
using System.Linq;
namespace LogicBubbleSort.NUnit.Tests
{
	public class MinElementIncrease : IComparer
	{
		public int Compare(int[] lhs, int[] rhs) => lhs.Min() - rhs.Min();
	}
}
