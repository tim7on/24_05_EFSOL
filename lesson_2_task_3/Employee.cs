using System;

namespace lesson_2_task_3
{
    partial class Employee
    {
        private string name;
        private string surname;
        private string position;
        private int experience;
        private double tax;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        private string Name
        {
            get { return name; }
        }

        private string Surname
        {
            get { return Surname; }
        }

        public string Position
        {
            private get { return position; }
            set { position = value; }
        }

        public int Experience
        {
            private get { return experience; }
            set { experience = value; }
        }

        private double Tax
        {
            get { return Tax; }
            set { tax = value; }
        }
    }
}
