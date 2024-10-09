using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_6_
{
    internal class Program
    {
        //1
        static int getDays(DateTime date1, DateTime date2)
        {
            return (date2 - date1).Days;
        }

        //2
        static void numInStr(string[] arr)
        {
            List<string> list = new List<string>();
            foreach (var item in arr)
            {
                if (Regex.IsMatch(item, @"\d+"))
                {
                    list.Add(item.ToString());
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }



        //3)
        static string reverseOdd(string input)
        {
            var words = input.Split(' ');
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

        //4
        static bool isPandigital(long number)
        {
            string numberStr = number.ToString();
            return numberStr.Distinct().Count() == 10 && numberStr.All(char.IsDigit);
        }
        static void Main(string[] args)
        {
          
            Console.WriteLine(getDays(new DateTime(2019, 6, 14), new DateTime(2019, 6, 20))); 
            Console.WriteLine(getDays(new DateTime(2018, 12, 29), new DateTime(2019, 1, 1))); 

          

        

            // Test for reverseOdd
            Console.WriteLine(reverseOdd("Bananas")); 
            Console.WriteLine(reverseOdd("One two three four"));

            // Test for isPandigital
            Console.WriteLine(isPandigital(98140723568910)); 
            Console.WriteLine(isPandigital(90864523148909)); 
        }
    }
}
