using System;

namespace Tutorial_Lab1
{
    class Program
    {
        static void Main()
        {
            var car1 = new Car("red", 2020, 44000);
            var car2 = new Car("blue", 2018);
            car2.Mileage = 50000;
            var car3 = new Car(2017, 50000);
            car3.Color = "black";
            int no_of_cars = Car.CountCars();
            Console.WriteLine($"Total Number of cars  in the Inventory : {no_of_cars} ");
            car1.display_cars();
            car2.display_cars();
            car3.display_cars();

        }
    }
}
