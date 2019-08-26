using MyModels;
using System;

namespace IntroToCSharp
{
    // Hey man, run Program.Main <= since main is static, this is feasible
    class Program
    {
        static void Main(string[] args)
        {
            //var boat = new Vehicle();
            //boat.NumberOfDoors = 0;
            //boat.GoesOnRoad = false;
            //boat.GoesOnSea = true;
            //boat.Name = "Titanic";
            //boat.NumberOfWheels = 0;

            //var fiatPunto = new Vehicle();
            //fiatPunto.NumberOfWheels = 4;
            //fiatPunto.NumberOfDoors = 5;
            //fiatPunto.Name = "Fiat Punto";
            //fiatPunto.GoesOnSea = false;
            //fiatPunto.GoesOnRoad = true;

            var school = new School(); //new MyModels.School();
            school.SchoolName = "Strive School";

            Console.WriteLine("Now we have " + Student.StudentCount + " students");

            var student1 = new Student("1231223123");
            student1.Name = "Valerio";
            student1.Surname = "Fusco";
            student1.YearOfBirth = 1997;

            Console.WriteLine("Now we have " + Student.StudentCount + " students");

            var student2 = new Student("1231223123123");
            student2.Name = "Michele";
            student2.Surname = "Lunati";
            student2.YearOfBirth = 1977;

            Console.WriteLine("Now we have " + Student.StudentCount + " students");

            Console.WriteLine(student1.PrintFullName(false));
            //student1.NationalInsuranceNumber = "1231233333";


            //console.log("Hello Strive Class!");
            Console.WriteLine("Hello Strive Class!");

            int number; //Is for storing 32 bits integer
            float floatingPointNumber; //for storing 16bits decimal precision
            double doublePrecision; // for storing 32bits decimal precision

            short smallNumber; //integer with 8 bits...
            floatingPointNumber = 12.5f; //the f means float 16 bits
            doublePrecision = 123.123; //without f means double 32 bits

            string thisIsAString = "Hello Everybody";

            //255
            byte numberOfLives = 0;
            var myInteger = 123;
            string myString = "whatever";
            var myString2 = "whatever";

            int integerNumber = 12;
            float floatNumber = 12.5f;

            var x = 124.5f;
            var y = 123;

            var s = "123";
            y = (int)x;
            Console.WriteLine(y);

            y = int.Parse(s);

            if (x > y)
                Console.WriteLine("Bigger then");
            else
                Console.WriteLine("Lesser then");

            switch (x)
            {
                case 1: break;
                case 2: Console.WriteLine("Case 2"); break;
                default: Console.WriteLine("Not 1 or 2"); break;
            }

            for (var i = 0; i < 20; i++)
                Console.WriteLine(i);

            do
            {
                Console.WriteLine("looping");
            } while (false);

            while (false)
                Console.WriteLine("will never be executed");

            //AFTER THE COMPILER
            //=> string myString2 = "whatever"
            /*
             * switch(x){
             *  case 1: ...
             *  case 2: ...
             *  }
             * 
             * if (x == 1)
             *      ...
             * else if (x == 2)
             *      ...
             * */

            //JavaScript is in camelCase 
            //C# is in PascalCase
        }
    }
}
