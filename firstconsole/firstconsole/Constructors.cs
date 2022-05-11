using System;


// A constructor is a special method that is used to initialize objects.
// The advantage of a constructor, is that it is called when an object of a class is created.
// It can be used to set initial values for fields:

namespace Basic
{
    class Car
    {
        public string model;  // Create a field

                     // Create a class constructor for the Car class
        public Car( string modename)   // for constructor, Constructor name is same (match) with class name.
        {
            model = modename; // Set the initial value for model
        }
    }
    }
/*
 * Note that the constructor name must match the class name, and it cannot have a return type (like void or int).
    Also note that the constructor is called when the object is created.
 */