//using System;
//using System.Collections.Generic;
//using System.Text;


////DELEGATES - a type safe function pointer
////DELEGATES USAGE - delegates get static methods in params
////MULTICAST DELEGATES
////Note: A multicast delegate, invokes the methods in the invocation list, in the same order in which they are added.
////If the delegate has a return type other than void and if the delegate is a multicast delegate, only the value of the last invoked method will be returned.Along the same lines, 
////If the delegate has an out parameter, the value of the output parameter, will be the value assigned by the last method.
//public delegate void HelloFunctionDelegate(string Message);

//delegate bool isPromote(Employee e);

//public delegate void SampleDelegate();
//class Employee
//{
//    public int ID { get; set; }
//    public string name { get; set; }
//    public int salary { get; set; }
//    public int experience { get; set; }
//    public static void promoteEmp(List<Employee> e, isPromote isPromote)
//    {
//        foreach(Employee E in e)
//        {
//            //How can we use delegates to change this criteria of promoting without changing this class?
//            //if(E.experience >= 5)
//            //{
//            //    Console.WriteLine(E.name + " promoted");
//            //}
//            if (isPromote(E))
//            {
//                Console.WriteLine(E.name + " promoted");
//            }
//        }
//    }

//}

//namespace CSharp_basics
//{
//    class Tutorial36
//    {
//        static void Main()
//        {
//            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
//            del("Hello from delegate");

//            List<Employee> e = new List<Employee>();
//            e.Add(new Employee() { ID = 101, name = "Marry", salary = 5000, experience = 5 });
//            e.Add(new Employee() { ID = 102, name = "John", salary = 4000, experience = 4 });
//            e.Add(new Employee() { ID = 103, name = "Edon", salary = 6000, experience = 6 });
//            e.Add(new Employee() { ID = 104, name = "Todd", salary = 3000, experience = 3 });

//            isPromote isPromote = new isPromote(promote); //instead of making this and separate function, i can use inline syntax
//            Employee.promoteEmp(e, Employee=>Employee.experience>=5); //it is same as line 54 but less effort
//            //Employee.promoteEmp(e);
//            Employee.promoteEmp(e, isPromote);

//            SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
//            SampleDelegate del2 = new SampleDelegate(SampleMethodTwo);
//            SampleDelegate del3 = new SampleDelegate(SampleMethodThree);
//            // In this example del4 is a multicast delegate. You use +(plus) 
//            // operator to chain delegates together and -(minus) operator to remove.
//            SampleDelegate del4 = del1 + del2 + del3 - del2;

//            del4();

//        }
//        public static void Hello(string Message)
//        {
//            Console.WriteLine(Message);
//        }
//        public static bool promote(Employee e)
//        {
//            return e.experience >= 5 ? true : false;
//        }
//        public static void SampleMethodOne()
//        {
//            Console.WriteLine("SampleMethodOne Invoked");
//        }


//        public static void SampleMethodTwo()
//        {
//            Console.WriteLine("SampleMethodTwo Invoked");
//        }


//        public static void SampleMethodThree()
//        {
//            Console.WriteLine("SampleMethodThree Invoked");
//        }
//    }
//}
