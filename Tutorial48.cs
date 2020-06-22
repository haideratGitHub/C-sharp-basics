//using System;
//using System.Collections.Generic;
//using System.Text;

////DIFFERENCE BETWEEN TYPES AND TYPE MEMBERS
////in general classes, structs, enums, interfaces, delegates are called as types and fields, properties, constructors, methods etc., 
////that normally reside in a type are called as type members.

////In C# there are 5 different access modifiers.
////1. Private
////2. Protected
////3. Internal
////4. Protected Internal
////5. Public


////Type members can have all the access modifiers, where as types can have only 2 (internal, public) of the 5 access modifiers
//namespace CSharp_basics
//{
//    class Tutorial48
//    {
//        static void Main()
//        {
//            Customer c = new Customer();
//        }
//    }
//    public class Customer
//    {
//        #region Private Fields
//        private int _id;
//        private string _firstName;
//        private string _lastName;
//        #endregion

//        #region Properties
//        public int Id
//        {
//            get { return _id; }
//            set { _id = value; }
//        }
//        public string FirstName
//        {
//            get { return _firstName; }
//            set { _firstName = value; }
//        }
//        public string LastName
//        {
//            get { return _lastName; }
//            set { _lastName = value; }
//        }
//        #endregion

//        #region Methods
//        public string GetFullName()
//        {
//            return this._firstName + " " + this._lastName;
//        }
//        #endregion
//    }

//}
