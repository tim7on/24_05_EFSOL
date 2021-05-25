using lesson_4_task_2.Classes;
using lesson_4_task_2.Classes.SubClasses;
using System;

namespace lesson_4_task_2
{
    class Program
    {
        static void Main()
        {
            AbstractHandler xml = new XMLHandler();
            xml.Show();
            Console.WriteLine("\n\n");

            AbstractHandler txt = new TXTHandler();
            txt.Show();
            Console.WriteLine("\n\n");

            AbstractHandler doc = new DOCHandler();
            doc.Show();
            Console.WriteLine("\n\n");

            Console.ReadKey();
        }
    }
}
