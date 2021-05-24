using System;

namespace lesson_1_task_3.OurClass.SubClasses
{
    class Content
    {
        private string text;

        public string Text { private get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Text);
            Console.ResetColor(); 
        }
    }
}
