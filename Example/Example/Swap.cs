using System;


namespace Example
{
    public class Swap
    {
            public void swap()
        {
            Console.WriteLine("First Number ");
         
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x;
            x = y;
            y = z;
            Console.WriteLine("First Number = " + x);
            Console.WriteLine("Second Number =" + y);   



        }

    }
}
