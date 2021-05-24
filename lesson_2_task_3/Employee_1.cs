using System;

namespace lesson_2_task_3
{
    partial class Employee_1
    {
        private double salary = 10000;

        public void Show()
        {
            Console.WriteLine();
        }

        private double WhatPosition(string position)
        {
            double temp = 0;
            switch (position)
            {
                case ("финансовый директор"): temp = 1.30;
                    break;
                case ("технический директор"): temp = 1.25;
                    break;
                case ("директор по производству и выпуску продукции"): temp = 1.20;
                    break;
                case ("главный инженер"): temp = 1.15;
                    break;
                case ("руководитель кадрового отдела"): temp = 1.1;
                    break;
                case ("главный бухгалтер"): temp = 1.07;
                    break;
                case ("руководитель отдела торговли"): temp = 1.05;
                    break;
                case ("руководитель отдела закупок"): temp = 1.03;
                    break;
                case ("руководитель отдела по связям с общественностью"): temp = 1;
                    break;
            }

            return temp;
        }

        private double WhatExperience(int exp)
        {
            double percent = 0;

            if (exp < 5 && exp >= 1)
                percent = 1.05;
            else if (exp >= 5 && exp < 10)
                percent = 1.1;
            else if (exp >= 10 && exp < 15)
                percent = 1.15;
            else if (exp >= 15 && exp < 20)
                percent = 1.20;
            else if (exp >= 20 && exp < 25)
                percent = 1.25;
            else if (exp >= 25)
                percent = 1.30;
            return percent;
        }

        public void 
    }
}
