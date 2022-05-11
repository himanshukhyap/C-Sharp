using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate_Local_File
{
    public class AbstractionClass
    {
    
/*  Abstract Classes and Methods:---
        Data abstraction is the process of hiding certain details and showing only essential information to the user.
        Abstraction can be achieved with either abstract classes or interfaces.

The abstract keyword is used for classes and methods:-------

Abstract class: is a restricted class that cannot be used to create objects 
                (to access it, it must be inherited from another class).

Abstract method: can only be used in an abstract class, and it does not have a body. 
                 The body is provided by the derived class (inherited from).
            
An abstract class can have both abstract and regular methods:

*/

        public abstract class Animal  // internal accessable in same namespace withot initalization.
        {                               // Abstract class
            public abstract void animalSound();   // Abstract method (does not have a body)

            public void sleep()                     // Regular method
            {
                Console.WriteLine("Zzz");
            }
        }


        class Pig : Animal            // Derived class (inherit from Animal)
        {
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }
                    // Animal myObj = new Animal(); 
                    // Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')

    }


}
