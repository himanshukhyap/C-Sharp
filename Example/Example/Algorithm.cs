using System;


namespace Example
{
    public class Algorithm
    {
       public void triple()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1==num2)
            {
                int x = (num1 + num2)*3;
                Console.WriteLine(x);
            }
            else
            {
                int x = (num1 + num2);
                Console.WriteLine(x);
            }



        }
    }
}
