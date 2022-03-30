using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        public class EmployeeA
        {
            public string FirstName = "John";
            public string LastName = "Wayne";
            public int Id = 076;

        }
        public class EmployeeB
        {
            public string FirstName = "Sarah";
            public string LastName = "Parker";
            public int IdB = 986;

        }

        static void Main(string[] args)
        { }
     public static bool operator ==( EmployeeA Id ,  EmployeeB IdB)
        {
           
            return Equals( Id,  IdB);
        }

        public static bool operator !=(EmployeeA Id, EmployeeB IdB)
        {
            return !Equals(Id, IdB);
        }



    }
}

