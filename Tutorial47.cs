//using System;
//using System.Collections.Generic;
//using System.Text;


////MORE ABOUT ENUMS
////1. Enums are enumerations.
////2. Enums are strongly typed constants.Hence, an explicit cast is needed to convert from enum type to an integral type and vice versa.Also, an enum of one type cannot be implicitly assigned to an enum of another type even though the underlying value of their members are the same.
////3. The default underlying type of an enum is int.
////4. The default value for first element is ZERO and gets incremented by 1.
////5. It is possible to customize the underlying type and values.
////6. Enums are value types.
////7. Enum keyowrd (all small letteres) is used to create enumerations, where as Enum class, contains static GetValues() and GetNames() methods which can be used to list Enum underlying type values and Names.
//namespace CSharp_basics
//{

//    //// Default underlying type is int and the value starts at ZERO
//    //public enum Gender
//    //{
//    //    Unknown,
//    //    Male,
//    //    Female
//    //}


//    //// Gender enum underlying type is now short and the value starts at ONE
//    //public enum Gender : short
//    //{
//    //    Unknown = 1,
//    //    Male = 2,
//    //    Female = 3
//    //}


//    //// Enum values need not be in sequential order. Any valid underlying type value is allowed 
//    //public enum Gender : short
//    //{
//    //    Unknown = 10,
//    //    Male = 22,
//    //    Female = 35
//    //}


//    //// This enum will not compile, bcos the maximum value allowed for short data type is 32767. 
//    //public enum Gender : short
//    //{
//    //    Unknown = 10,
//    //    Male = 32768,
//    //    Female = 35
//    //}
//    class Tutorial47
//    {
//        public static void Main()
//        {
//            // This line will not compile. Cannot implicitly convert type 'Season' to 'Gender'. 
//            // An explicit conversion is required.
//            // Gender gender = Season.Winter;


//            // This line comiples as we have an explicit cast
//            //Gender gender = (Gender)Season.Winter;

//            int[] Values = (int[])Enum.GetValues(typeof(Gender));
//            Console.WriteLine("Gender Enum Values");
//            foreach (int value in Values)
//            {
//                Console.WriteLine(value);
//            }

//            Console.WriteLine();
//            string[] Names = Enum.GetNames(typeof(Gender));
//            Console.WriteLine("Gender Enum Names");
//            foreach (string Name in Names)
//            {
//                Console.WriteLine(Name);
//            }
//        }
//        //enum keyowrd (all small letteres) is used to create enumerations
//        //, where as Enum class, contains static GetValues() and GetNames() methods which can be used to list Enum underlying type values and Names.
//        public enum Gender : int
//        {
//            Unknown = 1,
//            Male = 2,
//            Female = 3
//        }
//    }
//}
