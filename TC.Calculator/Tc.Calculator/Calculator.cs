﻿using System;

namespace Tc
{
	public class Calculator
	{
		public string instance = "";

		public int Sum(int first, int second)
			=> first + second;

		public int DuplicateSum(int first, int second)
		{
			var b = first + second;
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}

			return first + second;
		}

		public async void Nothing()
		{

		}

		public int ReDuplicateSum(int first, int second)
		{
			var b = first + second;
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}
			for (int i = 0; i < second; i++)
			{
				first++;
			}
			for (int i = 0; i < second; i++)
			{
				first--;
			}

			return first + second;
		}

		public int Division(int first, int second)
		{
			if(second == 0)
				throw new InvalidOperationException(nameof(second));
			GC.Collect(2, GCCollectionMode.Optimized);
			return first / second;
		}
	}
}
