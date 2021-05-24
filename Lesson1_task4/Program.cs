using System;
/*Задание 4
Используя Visual Studio, создайте проект по шаблону Console Application. 
Требуется: 
Создать классы Point и Figure. 
Класс Point должен содержать два целочисленных поля и одно строковое поле. 
Создать три свойства с одним методом доступа get. 
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями 
аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти 
аргументов типа Point. 
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину 
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр 
многоугольника. 
Написать программу, которая выводит на экран название и периметр многоугольника.*/
namespace Lesson1_task4
{
    class Point
    {
        private int x, y;
        private string name;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
    class Figure
    {
        Point[] points;
        string name;
        double LengthSide(Point A, Point B)
        {
            int x = A.X - B.X;
            int y = A.Y - B.Y;
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        public void PerimeterCalculator()
        {
            double sum = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                sum += LengthSide(points[i], points[i + 1]);
               
            }
            Console.WriteLine($"Perimeter of {name} is {sum}");
        }
        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            name = "Triangle";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            name = "Quadrangle";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p5;
            name = "Pentagon";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Figure newFigure = new Figure(new Point(5, 6, "a"), new Point(8, 8, "b"), new Point(1, 5, "c"), new Point(2, 5, "d"));
            newFigure.PerimeterCalculator();
        }
    }
}
