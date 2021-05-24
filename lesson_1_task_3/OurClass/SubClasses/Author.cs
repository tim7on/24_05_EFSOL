using System;

namespace lesson_1_task_3.OurClass.SubClasses
{
    class Author
    {
        private string text;

        public string Text { private get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Text);
            Console.ResetColor(); 
        }
    }
}
