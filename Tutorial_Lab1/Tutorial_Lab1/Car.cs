using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Lab1
{
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        private static int instances = 0;

        public Car()
        {
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }

        public Car(string color, int year, int mileage)
        {
            this.Color = color;
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        public void display_cars()
        {
            Console.WriteLine($"This car is painted {this.Color}, was built in {this.Year}, and has {this.Mileage} miles on it.");

        }
    }
}
