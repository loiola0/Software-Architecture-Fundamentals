using System;
using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Interface;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            //creating a Bmx
            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(13);
            
            //creating a celta
            IFactory car = factory.GetVehicle("Car");
            car.Drive(78);

        }
    }
}
