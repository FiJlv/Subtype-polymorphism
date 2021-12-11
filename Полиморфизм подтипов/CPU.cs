using System;
using System.Collections.Generic;
using System.Text;

namespace Полиморфизм_подтипов
{
    class CPU : Product
    {
        public int Cores { get; set; }

        public CPU (double price, string name, double frequency, int cores)
        {
            Name = name;
            Price = price;
            Frequency = frequency;
            Cores = cores;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price/2;
        }

        public override string ToString()
        {
            return "Процессор";
        }

        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine($"Кол-во ядер : {Cores}");
        }
    }
}
