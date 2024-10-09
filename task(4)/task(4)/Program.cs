using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_
{
    internal class Program
    {
        //1
        static int avg(int[]num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++) {
            sum+= num[i];
            
            }
            return(sum/num.Length);
        }

        //2
        static int cube(int n)
        {
            return n * n * n;
        }

        //3
        static int[] getYear(int[] years)
        {
            List<int> result = new List<int>();

            foreach (int year in years)
            {
                if (year >= 1950)
                {
                    result.Add(year);
                }
            }

            return result.ToArray();
        }

        //4
        static int ageInDays(int age)
        {
           return  (age * 365);
        }

        //5
        static int numberOfLeg(int ch,int c,int p)
        {
            int total=(ch*2)+(c*4)+(p*4);
            return total;
        }

        //6


        //7
        static int power(int num)
        {
            return (int)Math.Pow(num, 2);

        }

        //8
        static bool IsLeapYear(int year)
        {
           
            if (year < 1900 || year > 2024)
            {
                Console.WriteLine("Year is out of range.");
                return false;
            }

           
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }

        //9

        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        static void numOfWord (string sentence)
        {
            Console.WriteLine(sentence.Split(' ').Length);
        }

    


    static void Main(string[] args)
        {
            //1--------------------------------------------
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {

                num[i] = Convert.ToInt32(Console.ReadLine());
            }
             Console.WriteLine("the avg is "+avg(num));
            //2---------------------------------------------
           int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the cube is "+cube(number));
            //3---------------------------------------------
            int[] Year = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            Console.WriteLine("the Year more then 1950 is ");
            int[] result = getYear(Year);
            foreach (int year in result) {
                Console.WriteLine(year);
            }
            //4-----------------------------------------------
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age in day is {ageInDays(age)}");
            //5-----------------------------------------------
            Console.WriteLine("the number of total leg is "+numberOfLeg(2, 3, 5));
            //6----------------------------------------------
            //7----------------------------------------------
            int pw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the power of number {power(pw)} ");
            //8---------------------------------------------
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"is the year leap {IsLeapYear(y)}");
            //9--------------------------------------------
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"is the number prime {IsPrime(p)}");








        }
    }
}
