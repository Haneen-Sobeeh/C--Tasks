using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_
{
    internal class Program
    {
        //1
        static int minToSec(int m)
        {
            return m * 60;
        }

        //2
        static int Increment(int number)
        {
            return number + 1;
        }

        //3
        static int fElmant(int[] arr)
        {
            return arr[0];
        }

        //4
        static double area(double b, double h)
        {
            return .5 * b * h;
        }

        //5
        static int[] evenNumberEvenIndex(int[] numbers)
        {
            List<int> newArray = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0 && numbers[i] % 2 == 0)
                {
                    newArray.Add(numbers[i]);
                }
            }

            return newArray.ToArray();

        }

        //6
        static string[] evenIndexOddLength(string[] s)
        {
            List<string> newArray = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0 && s[i].Length % 2 != 0)
                {
                    newArray.Add(s[i]);

                }


            }
            return newArray.ToArray();
        }


        //7
        static int[] powerElementIndex(int[] numbers) 
        {

            List<int> newArray = new List<int>();

            for(int i = 0;i < numbers.Length; i++)
            {
              int n=(int)Math.Pow(numbers[i],i);
                newArray.Add(n);    

            }

            return newArray.ToArray();
        }

        //8
        static int multiplication2(int n1,int n2)
        {
            return n1*n2;   
        }

        //8
        static int muti2(int start, int end)
        {
            int product = 1;

            
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }

            return product; 
        }

        //10
        static double aveArray(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Length;
        }

        static void Main(string[] args)
        {
            //1
            Console.WriteLine("minToSec(5) => " + minToSec(5)); 

            //2
            Console.WriteLine("Increment(7) => " + Increment(7)); 

            //3
            int[] testArray = { 1, 2, 3, 4 };
            Console.WriteLine("fElmant({1, 2, 3, 4}) => " + fElmant(testArray)); 

            //4
            Console.WriteLine("area(5, 10) => " + area(5, 10)); 

            //5
            int[] numbers1 = { 2, 3, 4, 5, 6 };
            Console.WriteLine("evenNumberEvenIndex({2, 3, 4, 5, 6}) => " + string.Join(", ", evenNumberEvenIndex(numbers1))); 

            //6
            string[] strings = { "apple", "banana", "cherry", "date", "fig" };
            Console.WriteLine("evenIndexOddLength({\"apple\", \"banana\", \"cherry\", \"date\", \"fig\"}) => " + string.Join(", ", evenIndexOddLength(strings))); 

            //7
            int[] powerNumbers = { 2, 3, 4 };
            Console.WriteLine("powerElementIndex({2, 3, 4}) => " + string.Join(", ", powerElementIndex(powerNumbers))); 

            //8
            Console.WriteLine("multiplication2(4, 5) => " + multiplication2(4, 5)); 

            //9
            Console.WriteLine("muti2(3, 6) => " + muti2(3, 6)); 

            //10
            int[] nums = { 1, 2, 3, 8, 9 };
            Console.WriteLine("aveArray({1, 2, 3, 8, 9}) => " + aveArray(nums)); 

            int[] nums2 = { 1, 2, 3, 8, 9, 77 };
            Console.WriteLine("aveArray({1, 2, 3, 8, 9, 77}) => " + aveArray(nums2));

        }
    }
}


