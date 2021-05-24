using System;

namespace lesson_2_task_4
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article = "flour";
        private int quantity = 50;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        private int Account
        {
            get { return account; }
        }

        private string Customer
        {
            get { return customer; }
        }
        private string Provider
        {
            get { return provider; }
        }
        private int Quantity
        {
            get { return quantity; }
        }
        private string Article
        {
            get { return article; }
        }

        public void Show()
        {
            Console.WriteLine(Account);
            Console.WriteLine(Customer);
            Console.WriteLine(Provider);
            Console.WriteLine(Quantity);
            Console.WriteLine(Article);
        }

        public double CostWithVat()
        {
            return (Quantity * 50) * 1.10;
        }
        public double CostWithoutVat()
        {
            return Quantity * 50;
        }
    }
}
