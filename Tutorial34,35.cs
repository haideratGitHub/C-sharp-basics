//using System;
//using System.Collections.Generic;
//using System.Text;


////PROBLEMS OF MULTIPLE INHEIRTANCE-prereq 21,23,24
////diamond problem in inheritance
////MULTIPLE CLASS INHERITANCE USING INTERFACES
////interfaces are the solution of diamond problem of multiple inheritance

//interface IA
//{
//    void Amethod();
//}
//class A : IA
//{
//    public void Amethod()
//    {
//        Console.WriteLine("A");
//    }
//}
//interface IB
//{
//    void Bmethod();
//}
//class B : IB
//{
//    public void Bmethod()
//    {
//        Console.WriteLine("B");
//    }
//}

//class AB : IA, IB
//{

//    public void Amethod()
//    {
//        Console.WriteLine("A");
//    }
//    public void Bmethod()
//    {
//        Console.WriteLine("B");
//    }
//}
//namespace CSharp_basics
//{
//    class Tutorial34
//    {
//        static void Main()
//        {
//            AB ab = new AB();
//            ab.Amethod();
//            ab.Bmethod();
//        }
//    }
//}
