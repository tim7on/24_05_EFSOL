using lesson_3_task_4.Classes;
using lesson_3_task_4.Classes.SubClasses;
using System;

namespace lesson_3_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine();

            if (key == "")
            {
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.OpenDocument();
                documentWorker.EditDocument();
                documentWorker.SaveDocument();
            }
            else if (key == "123")
            {
                ProDocumentWorker pro = new ProDocumentWorker();
                pro.OpenDocument();
                pro.EditDocument();
                pro.SaveDocument();
            }
            else if (key == "321")
            {
                ExpertDocumentWorker expert = new ExpertDocumentWorker();
                expert.OpenDocument();
                expert.EditDocument();
                expert.SaveDocument();
            }

            Console.ReadKey();
        }
    }
}
