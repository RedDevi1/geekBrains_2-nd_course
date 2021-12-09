using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.Lesson_1.Exercise_1
{
	public class SimpleNum
	{
		public double Num { set; get; }
		public SimpleNum(double number)
		{
			number = Num;
		}
		public bool IsSimpleNum (double num)
        {
			bool result = false;
			var d = 0;
			var i = 2;
			while (i < num)
			{
				if (num % i == 0)
                {
					d++;
					i++;
				}
				else
					i++;
			}
			if (d == 0)
				result = true;
			return result;			
		}		
	}	
}
