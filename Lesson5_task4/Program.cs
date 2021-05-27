using System;
/*Задание 4 
Используя Visual Studio, создайте проект по шаблону Console Application. 
Требуется: 
Создать класс Article, содержащий следующие закрытые поля: 
• название товара; 
• название магазина, в котором продается товар; 
• стоимость товара в гривнах. 
Создать класс Store, содержащий закрытый массив элементов типа Article. 
Обеспечить следующие возможности: 
• вывод информации о товаре по номеру с помощью индекса; 
• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров 
нет, выдать соответствующее сообщение; 
Написать программу, вывода на экран информацию о товаре. */
namespace Lesson5_task4
{
    class Article
    {
        public string Name { get; set; }
        public string StoreName { get; set; }
        public double Cost { get; set; }

        public string Detail()
        {
            return $"{Name} for {Cost} UAH from store: {StoreName}";
        }
        public Article(string name)
        {
            Name = name;
        }
        public Article(string name, string storeName, double cost)
        {
            Name = name;
            StoreName = storeName;
            Cost = cost;
        }

    }
    class Store
    {
        public Article[] articles;
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length) // Конец массива пустой из-за "Динамичности" только строго меньше
                {
                    return articles[index].Detail();
                }
                return $"Out of index";
            }
        }
        public string this[string index]
        {
            get
            {
                foreach (Article article in articles)
                {
                    if (article.Name == index)
                    {
                        return article.Detail();
                    }
                }
                return $"'{index}' not found.";
            }
        }
        public void Add(Article x)
        {
            int current = Convert.ToInt32(articles.Length);
            int size = current + 1;
            Array.Resize(ref articles, size);
            articles[current] = x;
        }
        public Store(int size)
        {
            articles = new Article[0]; 
        }
        public int Lenght() //Нужно было для проверки
        {
            return articles.Length;
        }
        public void ShowAll()
        {
            Console.WriteLine("\nAll Articles\n" + new string('*',30));
            foreach (Article article in articles)
            {
                Console.WriteLine(article.Detail());
                Console.WriteLine(new string('-', 15));
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Store newstore = new Store(0); // число не играет роли

            newstore.Add(new Article("Pepsi", "MacDonalds", 5.6)); 
            newstore.Add(new Article("Hamburger", "FastFood", 10.6));
            newstore.Add(new Article("Book", "CaveBooks", 15.0));

            Console.WriteLine(newstore["Hey"]);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(newstore[3]);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(newstore[2]);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(newstore["Pepsi"]);
            Console.WriteLine(new string('-', 30));
            newstore.ShowAll();
            Console.WriteLine(newstore.Lenght());


        }
    }
}
