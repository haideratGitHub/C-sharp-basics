//using System;
//using System.Collections.Generic;
//using System.Text;

////METHODS
////METHOD PARAMETERS
//namespace CSharp_basics
//{
//    class Tutorial16
//    {
//        static void Main()
//        {
//            Tutorial16 t = new Tutorial16();
//            t.anyFunction();

//            int i = 0;
//            t.addOne(ref i); //pass by reference

//            int s = 0;
//            int p = 0;
//            cal(20, 30,out s,out p);
//            Console.WriteLine("sum is {0} and product is {1} ", s, p);

//            int[] numbers = new int[3];
//            numbers[0] = 100;
//            numbers[1] = 101;
//            numbers[2] = 102;

//            //3 ways to call
//            paramsMethod();
//            paramsMethod(numbers);
//            paramsMethod(1, 2, 3, 4, 5);


//        }
//        public void anyFunction()
//        {
//            Console.WriteLine("Hello world");
//        }

//        public void addOne(ref int j)
//        {
//            j++;
//        }

//        public static void cal(int x, int y, out int sum, out int product)
//        {
//            sum = x + y;
//            product = x * y;
//        }

//        public static void paramsMethod(params int[] numbers)
//        {
//            Console.WriteLine("There are {0} elements ", numbers.Length);
//            foreach(int i in numbers)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}
