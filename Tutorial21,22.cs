//using System;
//using System.Collections.Generic;
//using System.Text;

////INHERITANCE
////METHOD HIDING

//public class Employee
//{
//    public string firstName;
//    public string lastName;

//    public void printFullName()
//    {
//        Console.WriteLine(firstName + " " + lastName);
//    }
//}

//public class PartTimeEmp : Employee
//{
//    //we can hide the parent function and invoke child. if we want to call parent as well use keyword base
//    //base.printFullname();
//    public void printFullName()
//    {
//        Console.WriteLine(firstName + " " + lastName + "- contractor");
//    }
//}

//public class FullTimeEmp : Employee
//{

//}
//namespace CSharp_basics
//{
//    class Tutorial21
//    {
//        static void Main()
//        {
//            PartTimeEmp PTE = new PartTimeEmp();
//            PTE.firstName = "Part time";
//            PTE.lastName = "Employee";
//            PTE.printFullName();

//            FullTimeEmp FTE = new FullTimeEmp();
//            FTE.firstName = "Full time";
//            FTE.lastName = "Employee";
//            FTE.printFullName();
//        }
//    }
//}
