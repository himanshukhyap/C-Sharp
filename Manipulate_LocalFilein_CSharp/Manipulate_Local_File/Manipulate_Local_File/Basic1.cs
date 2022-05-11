using System;
/*              \n New Line
                \t Tab	
                \b Back space
*/



namespace MainNameSpace.Part1
{

    //class is a container for data and methods
    public class Basic1
    {
   

        public string concateName(string fname, string middlename)
        {
            return fname + middlename;
        }
        public string concateName(string fname, int Lastname)
        {
            return fname;
        }

        public void concateName(string fname, string middlename, string lastName)
        {

            Console.WriteLine(fname + middlename + lastName);
        }
       
    public void arr()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
                Console.WriteLine("\n");
            }
        }
     public void num()
        {
            float num1 = 0.0f;
            double num2 = 0.0d;
            decimal num3 = 0.0m;
            num1 = 1/5.5f;
            num2 = 1/5.5d;
            num3 = 1/5.5m;
            Console.WriteLine("float is {0}",num1);
            Console.WriteLine("double is {0}",num2);
            Console.WriteLine("decimal is {0}", num3);
        }
        public void date()
        {
            var d = new DateTime();
            Console.WriteLine(d);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);
        }
         
        public void test1()
        {
            Console.WriteLine("Enter Int. number");
            var input = Console.ReadLine();
            if (int.TryParse(input, out _) ==true)
            {
            Console.WriteLine("Your Enter No. is {0}",input);
                Console.WriteLine($"Your Enter No. is {input}");
            }
            else
                Console.WriteLine("Wrong Input");
        }
        public void test2()
        {
            Console.WriteLine("Hello 'Himanshu'");
            // Console.WriteLine("Hello "Himanshu"");  //error
            Console.WriteLine("Hello \"Himanshu\"");
            //Console.WriteLine('Hello "Himanshu"');   //error
            Console.WriteLine("D:\\Himanshu\\C Sharp\\Manipulate_LocalFilein_CSharp\\Manipulate_Local_File");
            Console.WriteLine(@"D:\Himanshu\C Sharp\Manipulate_LocalFilein_CSharp\Manipulate_Local_File");

        }
        


    }
}
