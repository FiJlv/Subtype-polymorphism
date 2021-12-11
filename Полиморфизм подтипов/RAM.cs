using System;
using System.Collections.Generic;
using System.Text;

namespace Полиморфизм_подтипов
{
    class RAM : Product
    {
        public int MemorySize { get; set; }

        public RAM(double price, string name, double frequency, int memorysize)
        {
            Name = name;
            Price = price;
            Frequency = frequency;
            MemorySize = memorysize;
        }

        public override string ToString()
        {
            return "Оперативная память";
        }

        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine($"Кол-во памяти : {MemorySize}");
        }
    }
}
