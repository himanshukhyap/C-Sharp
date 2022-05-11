using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class enumExample
    {
      public  enum Level
        {
            Low,
            Medium,
            High
        }
        public void PrintDayName()

        {

            var name =  Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToList();
         
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine(name[i]);
            }

         
           
        }
    }
}
