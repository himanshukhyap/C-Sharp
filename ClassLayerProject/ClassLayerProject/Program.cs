using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAccessLayer;
using DataModel;

namespace ClassLayerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bizUserLayer = new UserBusinessAccess();

            Console.WriteLine("Enter User Name:");
            var username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            var password = Console.ReadLine();
            var outPut = bizUserLayer.AuthenticateUser(username, password);
            if (outPut == true)
            {
                Console.WriteLine("Login Success");
                Console.WriteLine("Do you wants change details: Yes or No");
                var ans = Console.ReadLine().ToLower();
                if (ans == "yes")
                {
                    Console.WriteLine("First Name:");
                    string fname = Console.ReadLine();
                    Console.WriteLine("Last Name:");
                    string lname = Console.ReadLine();
                    Console.WriteLine("Password:");
                    string Pass = Console.ReadLine();

                    bizUserLayer.UpdateUser(fname, lname, username, Pass);
                    Console.WriteLine("Updated!");
                }

                //Console.WriteLine("Your Name : "+ String.Concat(finaluserdata.FirstOrDefault().FirstName," ",finaluserdata.FirstOrDefault().LastName));


            }


        }
    }
}
