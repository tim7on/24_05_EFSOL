using System;

namespace Lesson2_task2
{
    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        void fromGRN(double money, double currency)
        {
            Console.WriteLine($"{money / currency}");
        }
        void toGRN(double money, double currency)
        {
            Console.WriteLine($"{currency * money}");
        }

        public void Convert(double money, string currency)
        {
            if (currency == "grn")
            {
                Console.WriteLine("Выберите в какую валюту конвертировать USD, EUR, RUB");
            }
            else { Console.WriteLine("Выберите в какую валюту конвертировать GRN"); }
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "usd":
                    if (currency == "grn")
                        {
                        fromGRN(money, this.usd);
                        }
                    break;
                case "eur":
                    if (currency == "grn")
                    {
                        fromGRN(money, this.eur);
                    }
                    break;
                case "rub":
                    if (currency == "grn")
                    {
                        fromGRN(money, this.rub);

                    }
                    break;
                case "grn":
                    if(currency == "usd")
                    {
                        toGRN(money, this.usd);
                    }
                    else if(currency == "eur")
                    {
                        toGRN(money, this.eur);
                    }
                    else if (currency == "rub")
                    {
                        toGRN(money, this.rub);
                    }
                    break;
            }
                       

        }
    }
    class Program
    {
        /*Задание 2 
Используя Visual Studio, создайте проект по шаблону Console Application. 
Требуется: 
Создать класс Converter. 
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
Converter(double usd, double eur, double rub). 
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, 
также программа должна производить конвертацию из указанных валют в гривну.
        */
        static void Main(string[] args)
        {
            Converter current = new Converter(50.52, 42.6, 0.50);
            Console.WriteLine("Введите сумму денег для конвертации");
            double money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Текущую валюту USD, EUR, RUB, GRN");
            string currency = Console.ReadLine().ToLower();
            if (currency == "usd" || currency == "eur" || currency == "rub"|| currency=="grn")
            {
                current.Convert(money, currency);
            }
            else
            {
                Console.WriteLine("Нет такой валюты");
            }
        }
    }
}
