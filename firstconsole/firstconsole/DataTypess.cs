using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class DataTypess
    {

        int i = 50;
        Console.WriteLine(i);             //50
            double y = 502.35;
        Console.WriteLine(y);               // 502.35
            float f = 25.52F;
        Console.WriteLine(f);           // 25.52
            char ch = 'a';
        Console.WriteLine(ch);          //a
            bool myBool = true;
        Console.WriteLine(myBool);          //true
            string s = "Kashyap";
        Console.WriteLine(s);               // Kashyap
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };





        int myInt = 10;
        double myDouble = 5.25;
        bool myBool1 = true;

        Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool1));   // convert bool to string
    }
}

