using System;
/*Задание 3 
Используя Visual Studio, создайте проект по шаблону Console Application. 
Требуется: 
Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void
Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
Написать программу, которая выполняет проигрывание и запись.*/
namespace Lesson4_task3
{
    interface IPlayable
    {
        void Play() {}
        void Pause() {}
        void Stop() {}    
    }
    interface IRecodable
    {
        void Record() { }
        void Pause() { }
        void Stop() { }
    }
    class Player : IRecodable, IPlayable
    {
        void IPlayable.Play() { Console.WriteLine("Песня воспроизводится"); }
        void IPlayable.Pause() { Console.WriteLine("Пауза"); }
        void IPlayable.Stop() { Console.WriteLine("Воспроизведение остановлено"); }
        void IRecodable.Record() { Console.WriteLine("Началась запись"); }
        void IRecodable.Pause() { Console.WriteLine("Запись на паузе"); }
        void IRecodable.Stop() { Console.WriteLine("Запись остановлена"); }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Player instance = new Player();
            IRecodable instanceRec = instance as IRecodable;
            IPlayable instacePlay = instance as IPlayable;
            Console.WriteLine("Добро пожаловать в проигрыватель\n" + new string('*',25));
            Console.WriteLine("Команды:\n" + new string('-',25));
            Console.WriteLine("1-Начать Запись");
            Console.WriteLine("2-Поставить запись на паузу");
            Console.WriteLine("3-Остановить запись");
            Console.WriteLine("4-Начать воспроизведение");
            Console.WriteLine("5-Поставить на паузу");
            Console.WriteLine("6-Остановить песню\n" + new string('-', 25));
            while (true)
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        instanceRec.Record();
                        break;
                    case 2:
                        instanceRec.Pause();
                        break;
                    case 3:
                        instanceRec.Stop();
                        break;
                    case 4:
                        instacePlay.Play();
                        break;
                    case 5:
                        instacePlay.Pause();
                        break;
                    case 6:
                        instacePlay.Stop();
                        break;
                    default:
                        Console.WriteLine("Неверная команда");
                        break;

                }
            }
        }
    }
}
