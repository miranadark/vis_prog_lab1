using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_programming_project
{
	class HW1
	{
		public static long QueueTime(int[] customers, int n)
		{
			int min_cash_desks_index = 0, max_cash_desks_index = 0;
			int[] cash_desks = new int[customers.Length];
			for (int i = customers.GetLowerBound(0); i <= customers.GetUpperBound(0); i++)
			{
				cash_desks[i] = customers[i];
			}
			for (int i = n; i <= cash_desks.GetUpperBound(0); i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (cash_desks[j] < cash_desks[min_cash_desks_index])
						min_cash_desks_index = j;
				}
				cash_desks[min_cash_desks_index] += cash_desks[i];
			}
			for (int i = 0; i < n; i++)
			{
				if (cash_desks[i] > cash_desks[max_cash_desks_index])
					max_cash_desks_index = i;
			}
			return cash_desks[max_cash_desks_index];
		}
	}
}
