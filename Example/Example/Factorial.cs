using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Factorial
    {
        public void fact()
        {
            Console.WriteLine("Enter any number to calculate Factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            int x=1;
            for (int i = 1; i <= num; i++)
            {
                    x   = x * i;  
            }

            Console.WriteLine(x);
        }

    }
}
