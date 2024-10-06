using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("enter the number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int smaller;

            if (num1 > num2)
            {
                smaller = num2;
            }
            else
            {
                { smaller = num1; }
            }
            Console.WriteLine($"the smaller number is {smaller}");
            Console.WriteLine("-----------------------------------------------------------");


            //2
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"the sign is +");
            }
            else
            {
                Console.WriteLine("the sign is -");

            }
            Console.WriteLine("-----------------------------------------------------------");


            //3
            int[] numbers = new int[3];
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Array.Sort(numbers);
            Console.WriteLine("Sorted numbers: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
            Console.WriteLine("-----------------------------------------------------------");

            //4
            int[] num = { 2, 5, -2, 6, 2, -11 };
            int max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max) { }
                max = num[i];
            }
            Console.WriteLine(max);
            Console.WriteLine("-----------------------------------------------------------");

            //5
            Console.Write("Input kilometers per hour: ");
            double K = double.Parse(Console.ReadLine());

            double mph = K * 0.621371;

            Console.WriteLine($"{K} kilometers per hour is {mph} miles per hour");
             Console.WriteLine("-----------------------------------------------------------");


           //6
            Console.Write("Input hours: ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Input minutes: ");
            int m = int.Parse(Console.ReadLine());

            int total = (h * 60) + m;

            Console.WriteLine("Total: {0} minutes.", total);
           Console.WriteLine("-----------------------------------------------------------");


            //7
            Console.Write("Input minutes: ");
            int Total = int.Parse(Console.ReadLine());

            int hs = total / 60;
            int min = total % 60;

             Console.WriteLine("-----------------------------------------------------------");

            //8
            string[] s = { "Hello world", "Hi,im haneen", "Programming", "Jordan", "have a nice time " };

            foreach (string sentence in s)
            {
                Console.WriteLine(sentence.PadRight(20, ' '));
             
            }
            Console.WriteLine("-----------------------------------------------------------");



            //9

            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            string result = ReverseOddLengthWords(input);
            Console.WriteLine("Modified sentence: " + result);
            Console.WriteLine("-----------------------------------------------------------");
        }

        // Method to reverse odd-length words
        static string ReverseOddLengthWords(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }
            }
            return string.Join(" ", words);
        }


    }
}

