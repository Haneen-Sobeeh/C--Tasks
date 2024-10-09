using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_7_.Program;

namespace Task_7_
{
    internal class Program
    {
        //1
        public class myClass
        {
            public void text()
            {
                Console.WriteLine("MyClass class has initialized!");
            }
        }

        //2
        public class intro
        {
            public void myName(string name)
            {
                Console.WriteLine($"Hello All, I am {name}");
            }

        }

        //3
        public class math 
        {
            public int Calculate(int num)
            {
                if (num <= 1) return 1;
                return num * Calculate(num - 1);
            }
        }

        //4
        public class ArraySorter
        {
            public void SortArray(int[] array)
            {
                Array.Sort(array);
                Console.WriteLine("Sorted array: { " + string.Join(", ", array) + " }");
            }
        }

        //5
        public class DateDifferenceCalculator
        {
            public string CalculateDifference(DateTime date1, DateTime date2)
            {
                var totalDays = (date2 - date1).Days;

                var years = totalDays / 365;
                totalDays %= 365;
                var months = totalDays / 30;
                totalDays %= 30;
                var days = totalDays;

                return $"{years} years, {months} months, {days} day{(days != 1 ? "s" : "")}.";
            }
        }


        //6
        public class DateConverter
        {
            public void ConvertStringToDate(string dateString)
            {
                DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
                Console.WriteLine($"Converted Date: {date:yyyy-MM-dd}"); // Output in yyyy-MM-dd format
            }
        }


        static void Main(string[] args)
        {
            //1
            myClass myclass = new myClass();

            //2
            intro myIntro = new intro();
            myIntro.myName("haneen");

            //3
            math math = new math();
            math.Calculate(6);

            //4
            ArraySorter sorter = new ArraySorter();
            int[] array = { 11, -2, 4, 35, 0, 8, -9 };
            sorter.SortArray(array);

            //5
            DateTime date1 = new DateTime(1981, 11, 03);
            DateTime date2 = new DateTime(2013, 09, 04);

            DateDifferenceCalculator calculator = new DateDifferenceCalculator();
            string difference = calculator.CalculateDifference(date1, date2);
            Console.WriteLine($"Difference: {difference}");


            //6
            string dateString = "12-08-2004";
            DateConverter converter = new DateConverter();
            converter.ConvertStringToDate(dateString);
        }
    }
}