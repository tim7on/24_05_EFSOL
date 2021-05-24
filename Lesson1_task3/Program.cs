using System;

namespace Lesson1_task3
{
     class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();
        public Book(string inTitle, string inAuthor, string inContent)
        {
            title.field = inTitle;
            author.field = inAuthor;
            content.field = inContent;
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
    class Title
    {
        public string field;
        public void Show()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(field);
        }
    }
    class Author
    {
        public string field;
        public void Show()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(field);
            Console.ResetColor();
        }
    }
    class Content
    {
        public string field;
        public void Show()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
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
            Book newBook = new Book("допустим","новая","Книга");
            newBook.Show();
        }
    }
}
