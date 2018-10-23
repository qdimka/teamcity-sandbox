using System;
using System.Collections.Generic;
using System.Text;

namespace Tc
{
	public class Calculator
	{
		public int Sum(int first, int second)
			=> first + second;

		public int Division(int first, int second)
		{
			if(second == 0)
				throw new InvalidOperationException(nameof(second));

			return first / second;
		}
	}
}
