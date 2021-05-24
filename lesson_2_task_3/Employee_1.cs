using System;
using System.Security.Cryptography;

namespace lesson_2_task_3
{
    partial class Employee_1
    {
        public void Show()
        {
            Console.WriteLine();
        }

        private int WhatPosition(string position)
        {
            int temp = 0;
            switch (position)
            {
                case ("финансовый директор"): temp = 1;
                    break;
                case ("технический директор"): temp = 2;
                    break;                
                case ("директор по производству и выпуску продукции"): temp = 3;
                    break;                
                case ("главный инженер"): temp = 4;
                    break;                
                case ("руководитель кадрового отдела"): temp = 5;
                    break;                
                case ("главный бухгалтер"): temp = 6;
                    break;                
                case ("руководитель отдела торговли"): temp = 7;
                    break;                
                case ("руководитель отдела закупок"): temp = 8;
                    break;                
                case ("руководитель отдела по связям с общественностью"): temp = 9;
                    break;
            }

            return temp;
        }

        private double WhatExperience(int exp)
        {
            double 

            if (exp < 5 && exp >= 1)
            {
                Console.WriteLine($"Ваша з/п с учетом премий: {salary * 1.10}");
            }
            else if (exp >= 5 && exp < 10)
            {
                Console.WriteLine($"Ваша з/п с учетом премий: {salary * 1.15}");
            }
            else if (exp >= 10 && exp < 15)
            {
                Console.WriteLine($"Ваша з/п с учетом премий: {salary * 1.25}");
            }
            else if (exp >= 15 && exp < 20)
            {
                Console.WriteLine($"Ваша з/п с учетом премий: {salary * 1.35}");
            }
            else if (exp >= 20 && exp < 25)
            {
                Console.WriteLine($"Ваша з/п с учетом премий: {salary * 1.45}");
            }
            else if (exp >= 25)
            {
                Console.WriteLine($"Ваша з/п с учетом премий: {salary * 1.50}");
            }
        }
    }
}
