using System;

namespace Tc
{
	public class Calculator
	{
		public string instance = "";

		public int Sum(int first, int second)
			=> first + second;

		public int DuplicateSum(int first, int second)
			=> first + second;

		public int ReDuplicateSum(int first, int second)
			=> first + second;

		public int Division(int first, int second)
		{
			if(second == 0)
				throw new InvalidOperationException(nameof(second));
			GC.Collect(2, GCCollectionMode.Optimized);
			return first / second;
		}
	}
}
