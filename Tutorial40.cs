//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;

////EXCEPTION HANDLING
//namespace CSharp_basics
//{
//    class Tutorial40
//    {
//        public static void Main()
//        {
//            //This line will throw FileNotFoundException
//            //StreamReader streamReader1 = new StreamReader("C:\\NonExistingFile.txt");
//            //Console.WriteLine(streamReader1.ReadToEnd());
//            ////Closes the underlying stream and releases the system resources.
//            ////If there is an exception before this line, the below line will never
//            ////be executed and the resources are not relased
//            //streamReader1.Close();

//            StreamReader streamReader = null;
//            try
//            {
//                // This line will throw FileNotFoundException
//                streamReader = new StreamReader("C:\\NonExistingFile.txt");
//                Console.WriteLine(streamReader.ReadToEnd());
//            }
//            // This catch block handles only FileNotFoundException
//            catch (FileNotFoundException fileNotFoundException)
//            {
//                // Log or email the exception
//                // Code to log or email exception details


//                // Display meaningful error message to the end user
//                Console.WriteLine("Please check if the file \"{0}\" is present", fileNotFoundException.FileName);
//            }
//            // This catch block handles all the other exceptions
//            catch (Exception exception)
//            {
//                Console.WriteLine(exception.Message);
//            }
//            finally
//            {
//                if (streamReader != null)
//                {
//                    streamReader.Close();
//                }
//            }
//        }
//    }
//}

