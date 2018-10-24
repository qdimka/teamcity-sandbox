using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tc.CalculatorTest
{
	public class CalculatorTests
	{
		private readonly Calculator _calculator;

		public CalculatorTests()
		{
			_calculator = new Calculator();
		}

		[Fact(DisplayName = "Метод возвращает сумму двух элементов")]
		public void SumReturnSumOfTwoIntegersTest()
		{
			var first = 1;
			var second = 3;
			var expected = 4;

			var actual = _calculator.Sum(first, second);
			var actualTwo = _calculator.DuplicateSum(first, second);
			var actualThree = _calculator.DuplicateSum(first, second);

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualTwo);
			Assert.Equal(expected, actualThree);
		}

		[Fact(DisplayName = "Метод бросает исключение InvalidOperationException при попытке деления на ноль")]
		public void DivisionThrowsInvalidOperationExceptionForDivisionByZero()
		{
			var first = 1;
			var second = 0;

			Assert.Throws<InvalidOperationException>(() => _calculator.Division(first, second));
		}
	}
}
