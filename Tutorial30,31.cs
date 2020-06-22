//using System;
//using System.Collections.Generic;
//using System.Text;


////INTERFACES - serves the purpose of abstract classes
////interfaces only have declarations but not implementation
////interfaces members are public by default
////interfaces cannot contain fields
////a class can inherit from more than one interfaces but cannot inherit from more than one class
////we cannot create instance of interface

////EXPLICIT INTERFACE IMPLEMENTATION
////if a class inheriting from more than one interfaces and they contain same methods name then we have to implement them explicitly
//interface ICustomer
//{
//    void print();
//}

//interface I2
//{
//    void I2method();
//}
//class Customer : ICustomer,I2
//{
//    public void I2method()
//    {
//        Console.WriteLine("I2 method");
//    }

//    public void print()
//    {
//        Console.WriteLine("interface method");
//    }
//}
//namespace CSharp_basics
//{
//    class Tutorial30
//    {
//        static void Main()
//        {

//        }
//    }
//}
