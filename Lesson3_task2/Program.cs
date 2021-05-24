using System;
/*
 * Задание 2 
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
        public ClassRoom(Pupil name)
        {
           
        }
    }
    class Pupil
    {
        void Study() 
        {
            Console.WriteLine("Учиться на 3");
        }
        void Read() {
            Console.WriteLine("Читает на 3");
        }
        void Write() {
            Console.WriteLine("Пишет на 3");
        }
        void Relax() {
            Console.WriteLine("Отдыхает на 3");
        }
    }
    class ExcelentPupil : Pupil
    {
        void Study()
        {
            Console.WriteLine("Учиться на 5");
        }
        void Read()
        {
            Console.WriteLine("Читает на 5");
        }
        void Write()
        {
            Console.WriteLine("Пишет на 5");
        }
        void Relax()
        {
            Console.WriteLine("Отдыхает на 0");
        }
    }
    class GoodPupil : Pupil
    {
        void Study()
        {
            Console.WriteLine("Учиться на 4");
        }
        void Read()
        {
            Console.WriteLine("Читает на 4");
        }
        void Write()
        {
            Console.WriteLine("Пишет на 4");
        }
        void Relax()
        {
            Console.WriteLine("Отдыхает на 1");
        }
    }
    class BadPupil : Pupil
    {
        void Study()
        {
            Console.WriteLine("Учиться на 2");
        }
        void Read()
        {
            Console.WriteLine("Читает на 2");
        }
        void Write()
        {
            Console.WriteLine("Пишет на 2");
        }
        void Relax()
        {
            Console.WriteLine("Отдыхает на 5");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
