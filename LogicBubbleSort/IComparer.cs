using System;
namespace LogicBubbleSort
{
	public interface IComparer
	{
		int Compare(int[] lhs, int[] rhs);
	}
}