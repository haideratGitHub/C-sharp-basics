//using System;
//using System.Collections.Generic;
//using System.Text;

////DATATYPES CONVERSIONS
//namespace CSharp_basics
//{
//    class Tutorial7
//    {
//        static void Main()
//        {
//            int i = 100;
//            float f = i; //implicit conversions when there is no loss of any data
//            Console.WriteLine(f);

//            float f2 = 123.45F;
//            int i2 = (int)f2; //explicit conversion when there is loss of some data
//            //OR
//            int i3 = Convert.ToInt32(f2);
//            Console.WriteLine(i2);
//            Console.WriteLine(i3);

//            string str = "100";
//            int i4 = int.Parse(str); //use this if pretty sure about exact conversion
//            Console.WriteLine(i4);

//            string str2 = "100TG";
//            int result = 0;
//            bool isSuccesfull = int.TryParse(str2, out result); //use this if not sure about the conversion
//            if (isSuccesfull)
//            {
//                Console.WriteLine(result);
//            }
//            else
//            {
//                Console.WriteLine("enter valid number"); 
//            }
//        }
//    }
//}
