using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string lines = "";
            string path = @"C:\Users\Haneen\Desktop\C#\info.txt";


            using (StreamWriter sw = new StreamWriter(path)) 
            {
                sw.WriteLine("Haneen Sobeeh");
                sw.WriteLine("Software engineer");
                sw.WriteLine("I'm 21 years old ");
                sw.WriteLine("here i'm trainig in Orange Coding School");
            }

           
            //2
            using (StreamReader sr = new StreamReader(path)) 
            {
                string l;
                while ((l = sr.ReadLine()) != null)
                {
                    lines += l+"\n";
                }
            }
            Console.WriteLine("File content:\n" + lines);


            //3
            int sum = 0;
            for (int i = 0; i < lines.Length; i++) 
            {
                if (char.IsLetter(lines[i])) 
                {
                    sum++;
                
                }    
            }
            Console.WriteLine($"The Total Number of letter in file is : {sum}");
            Console.WriteLine("--------------------------------------");
            string []word=lines.Split(' ');
            int wordCounter = 0;

            foreach (var item in word)
            {
                ++wordCounter;
            }

            Console.WriteLine("The Total Number of Word in file is "+wordCounter);
        }
    }
}
