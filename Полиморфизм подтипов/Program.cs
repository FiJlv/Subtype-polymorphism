using System;

namespace Полиморфизм_подтипов
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Alex", "Golden street", 600, 300);
            Informer informer = new Informer();

            Product[] products = new Product[] { 
                new GPU(300, "RX570", 8, 4), 
                new CPU(200, "Xeon E52690", 3.4, 8),
                new RAM(50, "Good Memory", 2666, 16),
                new RAM(3, "Bad Memory", 866, 1)
            }; //UPCAST, тип массива product, а мы помещаем значение других типов. Product является родителем классов, экземпляры которых мы помещаем в массив.

            foreach (Product product in products)
            {
                product.ToConsole();
            }

            while (true)
            {
                Console.WriteLine($"Здравствуйте {user.Name}, Ваш баланс {user.Balance}");

                for(int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене { products[i].Price} ");
                }

                Console.WriteLine("Выберете номер товара и нажмите Enter");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                if (productNumber >= 0 && productNumber < products.Length)
                {
                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                }
                else
                {
                    Console.WriteLine("Таких товаров нет");
                }
            }
        }
    }
}
