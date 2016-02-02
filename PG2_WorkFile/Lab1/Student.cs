using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student
    {
        string fName;
        string lName;

        public Student(string first, string last)
        {
            fName = first;
            lName = last;
        }

        public string FirstName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lName;
            }

            set
            {
                lName = value;
            }
        }

        public override string ToString()
        {
            return (lName + ", " + fName);
        }
    }
}
