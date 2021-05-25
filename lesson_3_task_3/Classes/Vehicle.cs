using System;

namespace lesson_3_task_3.Classes
{
    class Vehicle
    {
        public int Price { private get; set; }
        public int Speed { private get; set; }
        public int YearIssue { private get; set; }

        public Vehicle(int price, int speed, int yearIssue)
        {
            Price = price;
            Speed = speed;
            YearIssue = yearIssue;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Стоимость: {Price}");
            Console.WriteLine($"Макс скорость: {Speed}");
            Console.WriteLine($"Год Выпуска: {YearIssue}");
        }
    }
}
