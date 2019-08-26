using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    //blue print of an object

    //is a definition which include methods and properties
    class Student 
    {
        public static int StudentCount;

        //Properties
        public string Name;
        public string Surname;
        public int YearOfBirth;
        public string NationalInsuranceNumber
        {
            get; private set;
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - YearOfBirth;
            }
        }

        //Constructor
        public Student(string nin)
        {
            this.NationalInsuranceNumber = nin;
            StudentCount++;
        }

        /*
         function foo(){
            ...
            return "123";
         }
        */
        public string PrintFullName(bool nameBefore = true)
        {
            return nameBefore ? Name + " " + Surname : Surname + " " + Name;
        }

    }
}
