//using System;
//using System.Collections.Generic;
//using System.Text;

////COMMON OPERATORS
//namespace CSharp_basics
//{
//    class Tutorial5
//    {
//        static void Main()
//        {
//            int number = 15;
//            bool isNumber10;

//            isNumber10 = number == 10 ? true : false; //ternary operator
//            Console.WriteLine(isNumber10);

//            //NULLABLE TYPES
//            //int i = null; illegal

//            int? i = null; //legal - nullable types bridge the difference between database types
//            string name = null; //legal

//            bool? areYouMajor = null;

//            if(areYouMajor == true)
//            {
//                Console.WriteLine("user is major");
//            }
//            else if (!areYouMajor.Value)
//            {
//                Console.WriteLine("user is not major");
//            }
//            else
//            {
//                //null
//                Console.WriteLine("user has not answered the question");
//            }

//            //NULL COALESCING OPERATOR
//            //converting int? type to some other type

//            int? ticketsOnSale = null;
//            int availableTickets = ticketsOnSale ?? 0; //if ticketsOnSale is null, it'll assign 0
//        }
//    }
//}
