using System;
/*
Задание 2 
Используя Visual Studio, создайте проект по шаблону Console Application. 
Требуется: 
Создать класс, представляющий учебный класс ClassRoom. 
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
Write(), void Relax(). 
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса 
Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика. 
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, 
писать, отдыхать
*/
namespace Lesson3_task2
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil pup1, Pupil pup2)
        {
            pupils[0] = pup1;
            pupils[1] = pup2;
            pupils[2] = rndPupil();
            pupils[3] = rndPupil();

        }
        public ClassRoom(Pupil pup1, Pupil pup2, Pupil pup3)
        {
            pupils[0] = pup1;
            pupils[1] = pup2;
            pupils[2] = pup3;
            pupils[3] = rndPupil();

        }
        private Pupil rndPupil()
        {
            Random rand = new Random();
            int rnd = rand.Next(1, 4);
            switch (rnd)
            {
                case 1: return new Pupil();
                case 2: return new GoodPupil();
                case 3: return new ExcelentPupil();
                default: break;
            }
            return new BadPupil();
        }
        public void Study()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i].Study();
            }
        }
        public void Read()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i].Read();
            }
        }
        public void Write()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i].Write();
            }
        }
        public void Relax()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i].Relax();
            }
        }
    }
    class Pupil
    {
        string name = "Pupil";
        public virtual void Study() 
        {
            Console.WriteLine($"{name} Учиться на 3");
        }
        public virtual void Read() {
            Console.WriteLine($"{name} Читает на 3");
        }
        public virtual void Write() {
            Console.WriteLine($"{name} Пишет на 3");
        }
        public virtual void Relax() {
            Console.WriteLine($"{name} Отдыхает на 3");
        }
    }
    class ExcelentPupil : Pupil
    {
        string name = "ExcelentPupil";
        public override void Study()
        {
            Console.WriteLine($"{name} Учиться на 5");
        }
        public override void Read()
        {
            Console.WriteLine($"{name} Читает на 5");
        }
        public override void Write()
        {
            Console.WriteLine($"{name} Пишет на 5");
        }
        public override void Relax()
        {
            Console.WriteLine($"{name} Отдыхает на 0");
        }
    }
    class GoodPupil : Pupil
    {
        string name = "GoodPupil";
        public override void Study()
        {
            Console.WriteLine($"{name} Учиться на 4");
        }
        public override void Read()
        {
            Console.WriteLine($"{name} Читает на 4");
        }
        public override void Write()
        {
            Console.WriteLine($"{name} Пишет на 4");
        }
        public override void Relax()
        {
            Console.WriteLine($"{name} Отдыхает на 1");
        }
    }
    class BadPupil : Pupil
    {
        string name = "BadPupil";
        public override void Study()
        {
            Console.WriteLine($"{name} Учиться на 2");
        }
        public override void Read()
        {
            Console.WriteLine($"{name} Читает на 2");
        }
        public override void Write()
        {
            Console.WriteLine($"{name} Пишет на 2");
        }
        public override void Relax()
        {
            Console.WriteLine($"{name} Отдыхает на 5");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pup1 = new ExcelentPupil();
            Pupil pup2 = new BadPupil();
            ClassRoom newClassRoom = new ClassRoom(pup1, pup2);
            newClassRoom.Read();
            Console.WriteLine("\n");
            newClassRoom.Write();
            Console.WriteLine("\n");
            newClassRoom.Study();
            Console.WriteLine("\n");
            newClassRoom.Relax();
        }
    }
}
