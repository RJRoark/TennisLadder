using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace DALTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass RJ = new TestClass();
            RJ.ID = 1;
            RJ.FirstName = "RJ";
            RJ.MiddleInitial = "J";
            RJ.LastName = "Roark";

            TestClass xx;

            xx = (TestClass) DAL.DAL.GetPlayer();

         }
    }

    class TestClass
    {
        private int _ID;
       
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _middleInit;

        public string MiddleInitial
        {
            get { return _middleInit; }
            set { _middleInit = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        
    }
}
