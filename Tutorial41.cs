//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;

////INNER EXCEPRIONS
////To look at the inner exception, you have to make this program cuase an exception fail.To do that you have 3 options
////1. Enter a Character instead of a number (Causes Format Exception)
////2. Or Enter a very big number that an interger cannot hold (Causes Over Flow Exception)
////3. Or Enter Zero for Second Number (Causes Divide By Zero Exception)
//namespace CSharp_basics
//{
//    class Tutorial
//    {
//        public static void Main()
//        {
//            try
//            {
//                try
//                {
//                    Console.WriteLine("Enter First Number");
//                    int FN = Convert.ToInt32(Console.ReadLine());


//                    Console.WriteLine("Enter Second Number");
//                    int SN = Convert.ToInt32(Console.ReadLine());


//                    int Result = FN / SN;
//                    Console.WriteLine("Result = {0}", Result);
//                }
//                catch (Exception ex)
//                {
//                    string filePath = @"D:\Sample Files\Log.txt";
//                    if (File.Exists(filePath))
//                    {
//                        StreamWriter sw = new StreamWriter(filePath);
//                        sw.Write(ex.GetType().Name + ex.Message + ex.StackTrace);
//                        sw.Close();
//                        Console.WriteLine("There is a problem! Plese try later");
//                    }
//                    else
//                    {
//                        //To retain the original exception pass it as a parameter
//                        //to the constructor, of the current exception
//                        throw new FileNotFoundException(filePath + " Does not Exist", ex);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                //ex.Message will give the current exception message
//                Console.WriteLine("Current or Outer Exception = " + ex.Message);



//                //Check if inner exception is not null before accessing Message property
//                //else, you may get Null Reference Excception
//                if (ex.InnerException != null)
//                {
//                    Console.WriteLine("Inner Exception = ", ex.InnerException.Message);
//                }
//            }
//        }


//    }
//}
