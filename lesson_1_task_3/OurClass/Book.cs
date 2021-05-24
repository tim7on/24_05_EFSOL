using lesson_1_task_3.OurClass.SubClasses;

namespace lesson_1_task_3.OurClass
{
    class Book
    {
        Title title;
        Author author;
        Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
    }
}
