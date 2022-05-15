using System;
using System.Collections.Generic;
using System.Text;

namespace Number
{
    public class Number
    {
        
        private string _numbers;

        public Number()
        {
        }

        public int AddNumbers(string number_)
        {
            //if (number < 1 || number > 3000)
            //{
            //    throw  new IndexOutOfRangeException("The number supplied is out of the expected range (1 - 3000).");
            //}
            number_.Replace("/n", ",");
            var numbersList = number_.Split(',');
            int total = 0;
            foreach (var number in numbersList)
            {
               int n= Convert.ToInt32(number);
               if(n<0)
                {
                    throw new Exception("negatives not allowed");
                }
               else if(n>0)
                {
                    total += n;
                }
            }
            return total;
        }
    }
}
