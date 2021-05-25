using System;
using lesson_3_task_3.Classes.ClassesDaughters;

namespace lesson_3_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(10000, 50, 2015, 500, "IMH45364");
            ship.Show();
            Console.WriteLine("\n");

            Car car = new Car(45000, 180, 2019, "BMW", "M3");
            car.Show();
            Console.WriteLine("\n");

            Plane plane = new Plane(250000, 450, 2020, 25, 450);
            plane.Show();
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
