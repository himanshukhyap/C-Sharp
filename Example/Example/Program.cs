using System;
using Example.LINQ;

namespace Example
   
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Swap swapp = new Swap();   // swap is object.
                                       // Swap is class.
             swapp.swap();    */

            /*  OddNumber oddNumber = new OddNumber();
              oddNumber.odd();*/

            /* Factorial factorial = new Factorial();
             factorial.fact();*/
            /* string txt;
             do
             {
                 Algorithm algorithm = new Algorithm();
                 algorithm.triple();
                 Console.WriteLine("Do you want to Contionue..Yes or No ");
                 txt = Console.ReadLine().ToLower();    

             } while (txt == "yes");
             Console.WriteLine( "End.....");*/
            /* array array = new array();
               array.ArrayFunction();*/
            /*  Login log  = new Login();
                 log.login();*/
            /* var ans = (int) enumExample.Level.High;
             Console.WriteLine(ans);  */
       //     var enumex = new enumExample();
       //     enumex.PrintDayName();

            //   var linqq = new LINQExample();
            /*           //   linqq.ArrayFun();  
                       linqq.GetDayName(); 

            */
            HowManyDaysTask howManyDaysTask = new HowManyDaysTask(); 
       
            Console.WriteLine(howManyDaysTask.HowManyDays(new DateTime(2005, 12, 8), DateTime.Now)); //4706
        }

    }
}