using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.LINQ
{
    /*
     Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
    Expected input and output
        [67, 92, 153, 15] → 67, 92
    */
    public class LINQExample
    {
        public void ArrayFun()
        {
            List<int> Numbers = new List<int> { 30, 54, 3, 14, 25, 82, 1, 101, 23, 95 };

            var result = Numbers.Where(x => x > 30 && x < 100).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
       
    }
}

