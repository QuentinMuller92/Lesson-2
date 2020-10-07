using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        private static int Task1MeAfterTen()
        {
            int age = 0;
            while (age < 1)
            {
                Console.Write("How old are you? ");
                int.TryParse(Console.ReadLine(), out age);
                if (age < 1)
                    Console.Clear();
            }
            age += 10;
            return age;
        }

        private static void CorrectionMeAfterTen()
        {
            Console.Write("Please enter your age: ");
            string ageAsString = Console.ReadLine();

            //Version 1
            //int ageAsInt = int.Parse(ageAsString);

            //int AgeAfterTen = ageAsInt + 10;

            //Console.WriteLine($"Your age after ten years will be {AgeAfterTen} years.");

            //Version 2
            bool parseResult = int.TryParse(ageAsString, out int ageAsInt);
            if(parseResult == true)
            {
                int ageAfterTen = ageAsInt + 10;
                Console.WriteLine($"Your age after ten years will be {ageAfterTen} years.");
            }
            else
            {
                Console.Write("Error!");
            }
        }

        private static void Task2SimpleFormulas()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("---------");

            Console.Write("Please enter side A: ");
            int sideA = int.Parse(Console.ReadLine());

            Console.Write("Please enter side B: ");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + sideA * sideB);

            Console.WriteLine("Perimeter = " + 2 * (sideA + sideB));

            Console.WriteLine("Triangle");
            Console.WriteLine("---------");

            Console.Write("Please enter side A: ");
            int sideAA = int.Parse(Console.ReadLine());

            Console.Write("Please enter side B: ");
            int sideBB = int.Parse(Console.ReadLine());

            Console.Write("Please enter side C: ");
            int sideC = int.Parse(Console.ReadLine());

            Console.Write("Please enter height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + (sideAA * height) / 2);

            Console.WriteLine("Perimeter = " + (sideAA + sideBB + sideC));
        }

        private static void Task3_Dates()
        {
            DateTime date = DateTime.Now;

            Console.Write("Current date: ");
            Console.WriteLine(date.ToShortDateString());

            Console.Write("Current time: ");
            Console.WriteLine(date.ToShortTimeString());

            Console.Write("Date after 10 years: ");
            Console.WriteLine(date.AddYears(10).ToShortDateString());

            Console.Write("Please enter a period: ");
            int period = int.Parse(Console.ReadLine());
            Console.Write($"Date after {period} years: ");
            Console.WriteLine(date.AddYears(period).ToShortDateString());
            Console.ReadKey();
        }
        
        private static void Task4_FutureBDay()
        {
            Console.Write("Current age: ");
            int currentAge = int.Parse(Console.ReadLine());

            Console.Write("Future age: ");
            int futureAge = int.Parse(Console.ReadLine());

            Console.Write("Bday month: ");
            int bdayMonthAge = int.Parse(Console.ReadLine());

            Console.Write("Bday day: ");
            int bdayDay = int.Parse(Console.ReadLine());

            int ageDifference = futureAge - currentAge;

            int futureYear = DateTime.Now.Year + ageDifference;

            var futureBDay = new DateTime(futureYear, bdayMonthAge, bdayDay);

            Console.WriteLine($"Your future bday will be: {futureBDay}");
        }

        private static void HelloName()
        {
            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("\nHello\n" + name);
        }

        private static void Sum()
        {
            Console.WriteLine("Number 1 : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Number 2 : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("N1 + N2 = " + (n1 + n2));
        }

        private static void SpecificsOperations()
        {
            double a = -1 + 4 * 6;
            Console.WriteLine("-1 + 4*6 = " + a);
            a = (35.0 + 5.0) % 7.0;
            Console.WriteLine("(35 + 5)%7 = " + a);
            a = 14.0 + (-4.0) * 6.0 / 11.0;
            Console.WriteLine("14 + (-4)*6/11 = " + a);
            a = 2.0 + 15.0 / 6.0 * 1.0 - 7.0 % 2.0;
            Console.WriteLine("2 + 15/6*1 - 7%2 = " + a);
        }
        
        private static void Multiplication()
        {
            Console.WriteLine("Number 1 : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Number 2 : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Number 3 : ");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("N1*N2*N3 = " + (n1*n2*n3));
        }

        private static void MultiplicationTable()
        {
            Console.Write("Number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i<=10; i++)
            {
                Console.WriteLine(n + "*" + i + " = " + n * i);
            }
        }

        private static void Average()
        {
            Console.Write("Number 1 : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Number 2 : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Number 3 : ");
            int n3 = int.Parse(Console.ReadLine());

            Console.Write("Number 4 : ");
            int n4 = int.Parse(Console.ReadLine());

            double average = (n1 + n2 + n3 + n4) / 4.0;
            Console.WriteLine(average);
        }

        private static void Range()
        {
            Console.WriteLine("Enter a number : ");
            int n = int.Parse(Console.ReadLine());

            if(n>=100 && n<=200)
            {
                Console.WriteLine("The number belongs to the range 100-200");
            }
            else
            {
                Console.WriteLine("The number doesn't belong to the range 100-200");
            }
       
        }

        private static void Date()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;

            Console.WriteLine("Current date: ");
            Console.WriteLine("Year --> " + year + "\nMonth --> " + month + "\nDay --> " + day);
        }

        private static void DateOfBirth()
        {
            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            int year = DateTime.Now.Year;

            Console.WriteLine("The year of your birth was the " + (year - age) + " year.");
        }

        private static void XYZ(double x, double y, double z)
        {
            Console.WriteLine("X = " + x + " Y = " + y + " Z = " + z);
            Console.WriteLine("(x + y) * z = " + ((x + y) * z));
            Console.WriteLine("x * y + y * z = " + (x * y + y * z));
        }

        static void Main(string[] args)
        {
            //int age = MeAfterTen();
            //Console.WriteLine("In ten years you will have " + age + " years!");

            //Task2SimpleFormulas();

            //Task3_Dates();

            //Task4_FutureBDay();

            //HelloName();

            //Sum();

            //SpecificsOperations();

            //Multiplication();

            //MultiplicationTable();

            //Average();

            //Range();

            //Date();

            //DateOfBirth();

            //XYZ(3, 4.5, 1.5);

            Console.ReadKey();
        }
    }
}
