using System;

namespace lesson_3_task_3.Classes.ClassesDaughters
{
    class Car : Vehicle
    {
        private string Brand { get; set; }
        private string Model { get; set; }

        public Car(int price, int speed, int yearIssue, string brand, string model)
            : base(price, speed, yearIssue)
        {
            Brand = brand;
            Model = model;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Авто");
            Console.WriteLine($"Марка авто: {Brand}");
            Console.WriteLine($"Модель: {Model}");
        }
    }
}
