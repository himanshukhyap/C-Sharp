using System;


namespace Example
{
    public class OddNumber
    {
       public void odd()
        {
            Console.WriteLine("Enter first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + "to" + num + "odd number given below:-");
            for (int i = num1; i < num; i++)
            {
               if (i%2== 1)
                {
                    Console.WriteLine(i);
                }
               
            }
        }
    }
}
