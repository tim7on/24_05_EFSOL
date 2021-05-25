using System;

namespace lesson_2_task_3
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Seldrick", "Jhons")
            {
                Position = "главный инженер",
                Experience = 10
            };

            employee.EmployeeInfo();
            Console.ReadKey();
        }
    }
}
