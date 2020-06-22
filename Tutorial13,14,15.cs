//using System;
//using System.Collections.Generic;
//using System.Text;

////WHILE LOOPS
////DO WHILE LOOPS
////FOR AND FOREACH LOOP
//namespace CSharp_basics
//{
//    class Tutorial13
//    {
//        static void Main()
//        {
//            string userChoice = string.Empty;
//            do
//            {
//                Console.WriteLine("Please enter your target");
//                int userTarget = int.Parse(Console.ReadLine());
//                int start = 0;
//                while (start <= userTarget)
//                {
//                    Console.Write(start + " ");
//                    start += 2;
//                }

//                do
//                {
//                    Console.WriteLine("Do you want to continue - Yes or No?");
//                    userChoice = Console.ReadLine().ToUpper();
//                    if (userChoice != "YES" && userChoice != "NO")
//                    {
//                        Console.WriteLine("Invalid. Please say Yes or No");
//                    }
//                } while (userChoice != "YES" && userChoice != "NO");

//            } while (userChoice == "YES");

//            int[] numbers = new int[3];
//            numbers[0] = 100;
//            numbers[1] = 101;
//            numbers[2] = 102;

//            for(int i = 0; i<numbers.Length; i++)
//            {
//                Console.WriteLine(numbers[i]);
//            }

//            foreach(int k in numbers)
//            {
//                Console.WriteLine(k);
//            }

//        }
//    }
//}
