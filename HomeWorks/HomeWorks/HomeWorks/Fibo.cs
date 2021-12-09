using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    public class Fibo
    {
        public int Num { set; get; }
        public Fibo (int num)
        {
            num = Num;
        }
        public int FiboByCycle (int number)
        {
            int num1, num2;
            num1 = 0; 
            num2 = 1;
            int fiboNum = 0;
            if (number == 1)
                fiboNum = num1;
            else if (number == 2)
                fiboNum = num2;
            for (int i = 1; i < number; i++)
            {
                fiboNum = num1 + num2;
                num1 = num2;
                num2 = fiboNum;
            }
            return fiboNum;
        }
        public int FiboByRecurse(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1 || number == 2)
                return 1;
            return FiboByRecurse(number - 1) + FiboByRecurse(number - 2);
        }
    }
}
