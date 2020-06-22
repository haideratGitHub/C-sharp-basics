//using System;
//using System.Collections.Generic;
//using System.Runtime.Serialization;
//using System.Text;

////CREATING CUSTOM EXCEPTIONS
////1. I have an asp.net web application.
////2. The application should allow the user to have only one logged in session.
////3. If the user is already logged in, and if he opens another browser window and tries to login again, the application should throw an error stating he is already logged in another browser window.
//namespace CSharp_basics
//{
//    class Tutorial42
//    {
//        public static void Main()
//        {
//            try
//            {
//                throw new UserAlreadyLoggedInException("User Already logged in");
//            }
//            catch (UserAlreadyLoggedInException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//    [Serializable]
//    public class UserAlreadyLoggedInException : Exception
//    {
//        public UserAlreadyLoggedInException(string message)
//            : base(message)
//        {
//        }


//        public UserAlreadyLoggedInException(string message, Exception innerException)
//            : base(message, innerException)
//        {
//        }

//        //If you want your Exception class object to work across application domains, then the object must be serializable.
//        //To make your exception class serializable mark it with Serializable attribute and provide a constructor that invokes the base Exception class constructor that takes in SerializationInfo and StreamingContext objects as parameters.
//        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
//            : base(info, context)
//        {
//        }
//    }

//}
