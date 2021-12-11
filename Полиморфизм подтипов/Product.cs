using System;
using System.Collections.Generic;
using System.Text;

namespace Полиморфизм_подтипов
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public double Frequency { get; set; }
        public virtual double GetDiscountPrice(User user)
        {
            if(user.Spent < 500)
            {
                return Price;
            }

            return Price * 0.9;    
        }

        public virtual void ToConsole()
        {
            Console.WriteLine(ToString() + ": ");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Частота: " + Frequency);
        }
    }
}
