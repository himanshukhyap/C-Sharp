using System;

namespace Example

{
   public class HowManyDaysTask
    {
        public int HowManyDays(DateTime dateInThePast, DateTime dateNow)
        {
            return (dateNow - dateInThePast).Days;
        }

       /*public static void Main()
        {
            Console.WriteLine(HowManyDays(new DateTime(2005, 12, 8), DateTime.Now)); //4706
        }*/
    }
}