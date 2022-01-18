using System;
using FactoryMethod.Interface;

namespace FactoryMethod.ConcreteProduct
{
    public class Car : IFactory
    {

        public void Drive(int kilometers)
        {
            Console.WriteLine($"Drive the Car for {kilometers} Km");
        }

    }
}