//using System;
//using System.Collections.Generic;
//using System.Text;

////INTRODUCTION TO CLASSES
////STATIC AND INSTANCE CLASS MEMBERS

//class Circle
//{
//    //these two are currently instance fields
//    float Pi = 3.14F;
//    int radius;

//    //if we make any of member static then every instance of class have same copy of only one static member 

//    static Circle()
//    {
//        //static constructor called only once, no matter how many instances you create of this class
        
//    }

//    public Circle() : this(-1) //the default constructor invoking parameterised constructor and assigning -1 to radius
//    {
//    }

//    public Circle(int radius)
//    {
//        this.radius = radius;
//    }

//    public float calculateArea()
//    {
//        return Pi * radius * radius;
//    }

//}
//namespace CSharp_basics
//{
//    class Tutorial19
//    {
//        static void Main()
//        {
//            Circle c1 = new Circle(5); //every instance has its own members
//            float area1 = c1.calculateArea();
//            Console.WriteLine("Area is {0} ", area1);
//        }
//    }
//}
