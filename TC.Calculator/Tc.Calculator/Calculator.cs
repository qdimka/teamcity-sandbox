using System;

namespace Tc
{
	public class Calculator
	{
		public int Sum(int first, int second)
			=> first + second;

		public int DuplicateSum(int first, int second)
			=> first;

		public int Division(int first, int second)
		{
			if(second == 0)
				throw new InvalidOperationException(nameof(second));

			return first / second;
		}
	}
}
