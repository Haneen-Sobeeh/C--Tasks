using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] ARR = { "1", "7", "9", "45" };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
            Console.WriteLine("-----------------------------------------------------");


            //2
            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine("Index of \"Banana\": 1\r\nIndex of \"Tomato\": 0");
            Console.WriteLine("-----------------------------------------------------");


            //3
            string[] Food = { "Pizza", "Sweet", "Burger", "Mansaf", "Ice Cream" };
            string[] Sport = { "Football", "Basketball", "Tennis" };
            string[] Movies = { "Movie", "Movie", "Movie", "Movie" };

            Console.WriteLine("Favorite Food:");
            foreach (string f in Food)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("\nFavorite Sport:");
            foreach (string s in Sport)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nFavorite Movies:");
            foreach (string m in Movies)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("\nFavorite Sport Again:");
            for (int i = 0; i < Sport.Length; i++)
            {
                Console.WriteLine(Sport[i]);
            }
            Console.WriteLine("-----------------------------------------------------");


            //4
            Console.WriteLine("enter the numbers");
            string num = Console.ReadLine();


            string[] numbers = num.Split(',');
            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int num3 = int.Parse(numbers[2]);

            int sum = num1 + num2 + num3;
            Console.WriteLine("The sum of three numbers: " + sum);
            Console.WriteLine("-----------------------------------------------------");

            //5
            int sm = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                    sm += i;
            }
            Console.WriteLine($"the sum of odd number is {sm}");
            Console.WriteLine("-----------------------------------------------------");


            //6

            int n = 3;

            for (int i = 1; i <= n; i++)
            {

                for (int j = i; j < n; j++)
                {
                    Console.Write("");
                }


                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------");


            //7
            int z = 4;
                int number = 1;

                for (int a = 1; a <= z; a++)
                {
                    // Print leading spaces
                    for (int j = a; j < z; j++)
                    {
                        Console.Write(" ");
                    }

                    // Print numbers
                    for (int k = 1; k <= a; k++)
                    {
                        Console.Write(number + " ");
                        number++;
                    }
                    Console.WriteLine();
                }



            }
        }
    }


