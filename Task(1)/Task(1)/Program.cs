using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Enter Your Name:");
            string myName = Console.ReadLine();
            Console.WriteLine($"My Name is: {myName} ");
            Console.WriteLine("-------------------------------------------------");

            //2
            int age = 10;
            string name = "Haneen";
            char grade = 'A';
            bool pass = true;
            double avg = 77.3;
            const int x = 22;

            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(grade);
            Console.WriteLine(pass);
            Console.WriteLine(avg);
            Console.WriteLine(x);
            Console.WriteLine("-------------------------------------------------");


            //3
            string[] cars = { "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine($"The length of array {cars.Length}");
            Console.WriteLine("-------------------------------------------------");

            //4
            Console.Write("Enter Your FirstName: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Your LastName: ");
            string lastName = Console.ReadLine();

            Console.Write("Enteryour year of birth: ");
            string yearOfBirth = Console.ReadLine();


            Console.WriteLine($"Your First Name is {firstName} and Your Last Name is {lastName} and Your Birth of Date is {yearOfBirth}");
            Console.WriteLine("-------------------------------------------------");

            //5
            int[] arr =new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"element - {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());


            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");


            //6
            int[] num = new int[4];
            int sum = 0;
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"index - {i} : ");
                num[i] = Convert.ToInt32(Console.ReadLine());  
                sum += num[i];  

            }
            Console.Write($"The sum is {sum}");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");


        }
    }
}
