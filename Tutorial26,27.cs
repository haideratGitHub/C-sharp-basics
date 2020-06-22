//using System;
//using System.Collections.Generic;
//using System.Text;


////PROPERTIES - encapsulate class members making them private and use getter and setter
////PROPERTIES - get the work of getters and setters using properties
//public class Student
//{
//    private int id;
//    private string name;
//    private string email;

//    //traditional getter and setter
//    //public void setId(int id)
//    //{
//    //    if( id <= 0)
//    //    {
//    //        throw new Exception("Id cannot be zero or negative");
//    //    }
//    //    else
//    //    {
//    //        this.id = id;
//    //    }
        
//    //}
//    //public int getId()
//    //{
//    //    return this.id;
//    //}

//    //properties
//    public int Id
//    {
//        set
//        {
//            if (value <= 0)
//            {
//                throw new Exception("Id cannot be zero or negative");
//            }
//            else
//            {
//                this.id = value;
//            }
//        }
//        get
//        {
//            return this.id;
//        }
//    }

//    //auto-implemented properties - we use them when there is no additional logic in accessors
//    public string Email
//    {
//        get;
//        set;
//    }

//    public void setName(string name)
//    {
//        if (string.IsNullOrEmpty(name))
//        {
//            throw new Exception("Name cannot be null or empty");
//        }
//        this.name = name;
//    }

//    public string getName()
//    {
//        return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
//    }

//}
//namespace CSharp_basics
//{
//    class Tutorial26
//    {
//        static void Main()
//        {

//        }
//    }
//}
