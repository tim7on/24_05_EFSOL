using System;

namespace lesson_3_task_3.Classes.ClassesDaughters
{
    class Plane : Vehicle
    {
        private int NumberPassengers { get; set; }
        private int Height { get; set; }

        public Plane(int price, int speed, int yearIssue, int numberPassengers, int height)
            : base(price, speed, yearIssue)
        {
            NumberPassengers = numberPassengers;
            Height = height;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Самолет");
            Console.WriteLine($"Количество пассажиров: {NumberPassengers}");
            Console.WriteLine($"Высота: {Height}");
        }
    }
}
