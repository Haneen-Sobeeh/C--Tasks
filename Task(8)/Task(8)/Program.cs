using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_
{
    internal class Program
    {
        public class Car
        {
            public string make;
            public int year;
            public string type;
            public double price;
            public string palletNo;
            public string model;
            public string color;
            public bool IsEngineRunning;

            public Car(string make, int year, string type, double price, string palletNo, string model, string color)
            {
                this.make = make;
                this.year = year;
                this.type = type;
                this.price = price;
                this.palletNo = palletNo;
                this.model = model;
                this.color = color;
                IsEngineRunning = false;
            }

            public void StartEngin()
            {
                if (!IsEngineRunning)
                {
                    IsEngineRunning = true;
                    Console.WriteLine($"The {color} {year} {make} {model}'s engine has started.");

                }
                else
                {
                    Console.WriteLine("The engine is already running.");
                }
            }

            public void StopEngine()
            {
                if (IsEngineRunning)
                {
                    IsEngineRunning = false;
                    Console.WriteLine($"The {color} {year} {make} {model}'s engine has stopped.");
                }
                else
                {
                    Console.WriteLine("The engine is already stopped.");
                }
            }
            public override string ToString()
            {
                return $"Make: {make}\n" +
                $"Year: {year}\n" +
                $"Type: {type}\n" +
                $"Price: ${price:F2}\n" +
                $"Model: {model}\n" +
                $"Pallet No: {palletNo}\n" +
                $"Color: {color}";
            }

        }

        public class ElectricCar : Car
        {
            public int BatteryCapacity;

            public ElectricCar(string make, int year, string type, double price, string model, string palletNo, string color, int batteryCapacity)
      : base(make, year, type, price, model, palletNo, color)
            {
                BatteryCapacity = batteryCapacity;
            }

            public override string ToString()
            {
                return base.ToString() + $"\nBattery Capacity: {BatteryCapacity} kWh";
            }
        }


        static void Main(string[] args)
        {

            var myCar = new Car("Toyota", 2022, "Sedan", 35000.99, "Corolla", "ABC123", "Blue");

            Console.WriteLine(myCar.ToString());
            Console.WriteLine();

            myCar.StartEngin();
            myCar.StopEngine();
            myCar.StartEngin();
            myCar.StopEngine();

            var electricCar = new ElectricCar("Tesla", 2023, "SUV", 60000.99, "Model Y", "XYZ789", "Red", 75);

            Console.WriteLine("\nElectric Car Details:");
            Console.WriteLine(electricCar.ToString());

            electricCar.StartEngin();
            electricCar.StopEngine();
        }
    }
}
