using System;

namespace lesson_4_task_2.Classes.SubClasses
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Документ открыт");
        }

        public override void Create()
        {
            Console.WriteLine("Документ создан");
        }

        public override void Chenge()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void Save()
        {
            Console.WriteLine("Документ сохранен в XML формате");
        }

        public override void Show()
        {
            Open();
            Create();
            Chenge();
            Save();
        }
    }
}
