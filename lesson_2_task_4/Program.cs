using System;

namespace lesson_2_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(123, "baker", "factory");

            invoice.Show();

            Console.WriteLine($"\n\n\nНДС: {invoice.CostWithVat()}");
            Console.WriteLine($"Без НДС: {invoice.CostWithoutVat()}");

            Console.ReadKey();
        }
    }
}
