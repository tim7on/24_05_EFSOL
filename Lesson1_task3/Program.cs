using System;

namespace Lesson1_task3
{
     public class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
    public class Title
    {
        string field;
        public string Property
        {
            get
            {
                return field;
            }
            set
            {
                field = value;
            }
        }
        public void Show()
        {
            Console.WriteLine(field);
        }
    }
    class Author
    {
        string field;
        public string Property
        {
            get
            {
                return field;
            }
            set
            {
                field = value;
            }
        }
        public void Show()
        {
            Console.WriteLine(field);
        }
    }
    class Content
    {
        string field;
        public string Property
        {
            get
            {
                return field;
            }
            set
            {
                field = value;
            }
        }
        public void Show()
        {
            Console.WriteLine(field);
        }
    }
    class Program
    {
        /*   Задание 3 
        Используя Visual Studio, создайте проект по шаблону Console Application. 
        Требуется: 
        Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать 
        одно строковое поле и метод void Show(). 
        Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
        Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и 
        содержание.
        */
        static void Main(string[] args)
        {
            
        }
    }
}
