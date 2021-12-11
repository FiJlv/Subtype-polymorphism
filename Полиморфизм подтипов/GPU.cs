using System;
using System.Collections.Generic;
using System.Text;

namespace Полиморфизм_подтипов
{
    class GPU : Product
    {
        public int VideoMemorySize { get; set; }

        public GPU(double price, string name, double frequency, int videomemorysize)
        {
            Name = name;
            Price = price;
            Frequency = frequency;
            VideoMemorySize = videomemorysize;
        }

        public override string ToString()
        {
            return "Видеокарта";
        }

        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine($"Кол-во видеопамяти : {VideoMemorySize}");
        }
    }
}
