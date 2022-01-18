using System;
using FactoryMethod.Interface;

namespace FactoryMethod.ConcreteProduct
{
    public class Bike : IFactory
    {

        public void Drive(int kilometers)
        {
            Console.WriteLine($"Drive the Bike for {kilometers} Km");
        }

    }
}