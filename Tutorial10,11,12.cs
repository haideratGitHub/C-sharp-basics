//using System;
//using System.Collections.Generic;
//using System.Text;

////IF STATEMENTS
////SWITCH STATEMENTS
////SWITCH STATEMENTS CONTINUED
//namespace CSharp_basics
//{
//    class Tutorial10
//    {
//        static void Main()
//        {
//            Console.WriteLine("enter a number");
//            int num = int.Parse(Console.ReadLine());

//            if(num == 10)
//            {
//                Console.WriteLine("number is 10");
//            }
//            else if(num == 20)
//            {
//                Console.WriteLine("number is 20");
//            }
//            else if(num == 30)
//            {
//                Console.WriteLine("number is 30");
//            }
//            else
//            {
//                Console.WriteLine("number is not 10,20 and 30");
//            }

//            switch (num)
//            {
//                case 10:
//                    Console.WriteLine("number is 10");
//                    break;
//                case 20:
//                    Console.WriteLine("number is 20");
//                    break;
//                case 30:
//                    Console.WriteLine("number is 30");
//                    break;
//                default:
//                    Console.WriteLine("number is not 10,20 and 30");
//                    break;

//            }

//            //multiple case statements
//            switch (num)
//            {
//                case 10:
//                case 20:
//                case 30:
//                    Console.WriteLine("number is {0}",num);
//                    break;
//                default:
//                    Console.WriteLine("number is not 10,20 and 30");
//                    break;

//            }

//            //switch statements continued - label
//            int totalCoffeeCost = 0;
//            start: //label
//            Console.WriteLine("1.small  2.medium  3.large");
//            int userChoice = int.Parse(Console.ReadLine());

//            switch (userChoice)
//            {
//                case 1:
//                    totalCoffeeCost += 1;
//                    break;
//                case 2:
//                    totalCoffeeCost += 2;
//                    break;
//                case 3:
//                    totalCoffeeCost += 3;
//                    break;
//                default:
//                    Console.WriteLine("Your choice {0} is invalid", userChoice);
//                    goto start;
//            }

//            tryAgain:
//            Console.WriteLine("Do you want to buy another coffee - Yes or No ?");
//            string userDecision = Console.ReadLine();

//            switch (userDecision)
//            {
//                case "Yes":
//                    goto start;
//                case "No":
//                    break;
//                default:
//                    Console.WriteLine("Your choice {0} is invalid. Try again...", userDecision);
//                    goto tryAgain;
//            }
//        }
//    }
//}
