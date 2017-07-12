using System;
using System.Linq;
namespace LogicBubbleSort.NUnit.Tests
{
	public class MaxElementIncrease : IComparer
	{
		public int Compare(int[] lhs, int[] rhs) => lhs.Max() - rhs.Max();
	}
}
