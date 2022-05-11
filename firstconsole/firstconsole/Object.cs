using System;


namespace Basic
{
    public class Object
    {
        public string model = "";
        public string Color { get; set; }    
        public int year;
    }
}/*
  declare fields/variables as private
provide public get and set methods, through properties, 
to access and update the value of a private field.

class Person
{
  private string name; // field
  public string Name   // property
  {
    get { return name; }
    set { name = value; }
  }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}

...................................Automatic Properties (Short Hand):-----------


class Person
{
  public string Name  // property
  { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}



  
  
  */