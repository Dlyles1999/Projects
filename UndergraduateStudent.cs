using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class UndergraduateStudent : Student
    {
        private string studentYear;
        private string homeTown;


       
        public UndergraduateStudent()
        {

        }

        public UndergraduateStudent(string fName, string lName, int sNumber, string sYear, string hTown)
         :base( fName,lName,sNumber)
        {
            studentYear = sYear;
            homeTown = hTown;
        }


        public UndergraduateStudent(string fName, string lName, string sYear, string hTown)
        : base(fName, lName)
        {
            studentYear = sYear;
            homeTown = hTown;
        }

        public string StudentYear
        {
            get
            {
                return studentYear;
            }

            set
            {
                studentYear = value; 
            }

        }

        public string HomeTown
        {
            get
            {
                return homeTown;
            }

            set
            {
                homeTown = value;
            }


        }





    }
}
