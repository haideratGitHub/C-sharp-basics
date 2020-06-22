//using System;
//using System.Collections.Generic;
//using System.Text;


////POLYMORPHISM
////DIFFERENCE BETWEEN METHOD OVERRIDING AND METHOD HIDING
////METHOD OVERLOADING
//public class Employee
//{
//    public string firstName = "FN";
//    public string lastName = "LN";

//    public virtual void printFullName()
//    {
//        Console.WriteLine(firstName + " " + lastName);
//    }
//}

//public class PartTimeEmp : Employee
//{
//    public override void printFullName()
//    {
//        Console.WriteLine(firstName + " " + lastName + "- contractor");
//    }
//}

//public class FullTimeEmp : Employee
//{
//    public override void printFullName()
//    {
//        Console.WriteLine(firstName + " " + lastName + "- Full time");
//    }
//}
//namespace CSharp_basics
//{
//    class Tutorial23
//    {
//        static void Main()
//        {
//            Employee[] e = new Employee[3];
//            e[0] = new Employee();
//            e[1] = new PartTimeEmp();
//            e[2] = new FullTimeEmp();

//            foreach (Employee E in e)
//            {
//                E.printFullName();
//            }
//        }
//    }
//}
