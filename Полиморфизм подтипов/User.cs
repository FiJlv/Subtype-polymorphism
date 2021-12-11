﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Полиморфизм_подтипов
{
    class User
    {   public string Name { get; private set; }
        public string Adress { get; private set; }
        public double Balance  { get; private set; }
        public double Spent { get; private set; }
        public User(string name, string adress, double balance, double spent)
        {
            Name = name;
            Adress = adress;
            Balance = balance;
            Spent = spent;
        }
        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }
    }
}
