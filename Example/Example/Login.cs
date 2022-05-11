using System;


namespace Example
{
     class Login
    {
        public void login()
        {
           

            
         
            int i = 1;
            do
            {
              
                Console.WriteLine("Enter a Id:");
                string Username = Console.ReadLine();
                Console.WriteLine("Enter a password:");
                string password = Console.ReadLine();
                if (Username == "himanshu" && password == "kashyap")
                {
                    Console.WriteLine("Login Successfuly");
                }
                else
                {
                    Console.WriteLine("Yor are wrong input");
                    Console.WriteLine("try again : Yes or No");
                    i++;
                }
            } while (Console.ReadLine().ToLower() == "yes" && i<4);
              
        }
        
      

    }
}
