/*
int myNum = 5;               // Integer (whole number)
double myDoubleNum = 5.99D;  // Floating point number
char myLetter = 'D';         // Character
bool myBool = true;          // Boolean
string myText = "Hello";     // String

*/

/*              \n New Line
                \t Tab	
                \b Back space
*/

using System;
//using System means that we can use classes from the System 
namespace Basic         //namespace is used to organize your code, and it is a container for classes and other namespaces.

{
    class BasicProgram                    //class is a container for data and methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");   /* Console is a class of the System namespace, which has a WriteLine()
                                                method ( function) that is used to output/print text.*/

            System.Console.WriteLine("Hellow");
            Console.Write("I will print on a new line.");

            ///*......................Data Type...........................*/
            


            /* .....................User Input/Output.............................*/

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            /*...............................................................................................*/

            Console.WriteLine("Himanshu KAshyap".ToUpper());
            Console.WriteLine("Himanshu KAshyap".ToLower());
            Console.WriteLine("Himanshu KAshyap".Length);
            string firstName = "himanshu";
            string Lastname = "Kashyap";
            string Name = firstName + Lastname;
            Console.WriteLine(Name);
            string Name1 = string.Concat(firstName, Lastname);
            Console.WriteLine(Name1);
            string name2 = $"My full name is: {firstName} {Lastname}";
            Console.WriteLine(name2);

            /*.......................Condition......................................*/
            int time = 20;
            if (time > 18)
            {
                Console.WriteLine("Good Days");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            //or.........................


            string result = (time > 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            //or.........................
            int t = 4;
            switch (t)
            {
                case 4:
                    Console.WriteLine("Correct");
                    break;
                case 5:
                    Console.WriteLine("Wrong");
                    break;
            }
            /* ............................Importing other classes.............................................*/
            Sample def = new Sample();
            Console.WriteLine(def.h);

            def.concateName("", "", "");




            Basic.abc.Sample2 def1 = new Basic.abc.Sample2();
            Console.WriteLine(def1.g);
            /* .........................................................................*/

            /*            ...............................Loopoing.........................................*/

            int w = 5;
            /*    while (w < 10)
                {
                    Console.WriteLine(w);
                    w++;
                }*/
            // Or..............................
            do
            {
                Console.WriteLine(w);
                w++;
            }
            while (w < 10);

            for (int k = 0; k <= 10; k = k + 2)
            {
                Console.WriteLine(k);
            }
            /* ................................Method....................................*/

            Method method = new Method();
            method.fun();
            Console.WriteLine(method.fun1(50));

            Console.WriteLine(method.MyMethod(50));
            Console.WriteLine(method.MyMethod(50.55));
            Console.WriteLine(method.MyMethod(50.55+50));

          /*  .........................Object.........................*/

            Object obj = new Object();
          
            obj.Color = "Red";
            obj.year = 2018;


            Object Opel = new Object();
            Opel.model = "Astra";
            Opel.Color = "white";
            Opel.year = 2005;

            Console.WriteLine(obj.Color);
            Console.WriteLine(Opel.model);

            /*...............................Construction.........................*/

            Car Ford = new Car("KAshyap Model");  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.model);        // Print the value of model
            Ford.model = "Changed MOdel";
            Console.WriteLine(Ford.model);

            /* .....................................................................*/

            Vehicle vehicle = new Vehicle();
           Console.WriteLine(vehicle.brand);
            vehicle.honk();
            jeep Jeep = new jeep();
            Console.WriteLine(Jeep.brand);
            Jeep.honk();
            Console.WriteLine(Jeep.modelName);
            /*            ....................................Polymorphism............................................*/

            /*    Animal myAnimal = new Animal();  // Create a Animal object
                Animal myPig = new Pig();  // Create a Pig object
                Animal myDog = new Dog();  // Create a Dog object

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();*/
           /* ...............................................................................................*/
           Pig pig = new Pig();
            pig.animalSound();
            /*....................................................................................................................*/
          
          

        }
    }
}