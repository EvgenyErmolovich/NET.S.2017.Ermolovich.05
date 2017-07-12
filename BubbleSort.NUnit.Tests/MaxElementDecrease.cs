using System;
using System.Linq;
namespace LogicBubbleSort.NUnit.Tests
{
	public class MaxElementDecrease : IComparer
	{
		public int Compare(int[] lhs, int[] rhs) => rhs.Max() - lhs.Max();
	}
}
