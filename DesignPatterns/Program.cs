﻿using DesignPatterns.Factory;
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ducks.CreateDucks();
            //ChatUsers.CreateUsers();
            //DecoratorFactory.MakeCoffee();
            //DecoratorFactory.MakeTea();
            BridgeFactory.MakePayment();

            Console.ReadLine();
        }
    }
}
