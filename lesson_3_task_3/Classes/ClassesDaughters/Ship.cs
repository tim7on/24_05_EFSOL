using System;

namespace lesson_3_task_3.Classes.ClassesDaughters
{
    class Ship : Vehicle
    {
        private int NumberPassengers { get; set; }
        private string HomePort { get; set; }

        public Ship(int price, int speed, int yearIssue, int numberPassengers, string homePort)
            : base(price, speed, yearIssue)
        {
            NumberPassengers = numberPassengers;
            HomePort = homePort;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Корабль");
            Console.WriteLine($"Количество пассажиров: {NumberPassengers}");
            Console.WriteLine($"Порт приписки: {HomePort}");
        }
    }
}
