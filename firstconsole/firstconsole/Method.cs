using System;               /*The void keyword, used in the examples above, indicates that the method should not return a value.
                             * If you want the method to return a value, you can use a primitive data type (such as int or double) 
                             * sinstead of void, and use the return keyword inside the method:*/

namespace Basic
{
    public class Method
    {

       public void fun()            
                                   
        {
            Console.WriteLine("I just got executed!");

          
        }
        public int fun1(int x = 100)
        {
            return 5 + x;
        }

        /*.....Note: Multiple methods can have the same name as long as 
         * the number and/or type of parameters are different............*/
        public int MyMethod(int x)
        {
            return x;
        }
      public double MyMethod(double x)
        {
            return x;
        }
        public double MyMethod(double x, double y)
        {
            return x+y;
        }
    }
}
