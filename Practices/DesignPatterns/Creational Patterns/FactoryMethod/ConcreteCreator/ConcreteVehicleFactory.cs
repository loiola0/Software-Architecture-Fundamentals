using System;
using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Interface;

namespace FactoryMethod.ConcreteCreator
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        
        public override IFactory GetVehicle(string vehicle)
        {
            switch(vehicle)
            {
                case "Bike":
                    return new Bike();
                case "Car":
                    return new Car();
                default:
                    throw new ApplicationException($"Vehicle {vehicle} cannot be created");

            }
        }

    }
}