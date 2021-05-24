using System;

namespace lesson_2_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("qwe", "qwe")
            {
                Position = "главный инженер",
                Experience = 10
            };
        }
    }
}
