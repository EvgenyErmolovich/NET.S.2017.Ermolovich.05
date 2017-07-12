using System;
using System.Linq;
namespace LogicBubbleSort.NUnit.Tests
{
	public class MinElementDecrease : IComparer
	{
		public int Compare(int[] lhs, int[] rhs) => rhs.Min() - lhs.Min();
	}
}
