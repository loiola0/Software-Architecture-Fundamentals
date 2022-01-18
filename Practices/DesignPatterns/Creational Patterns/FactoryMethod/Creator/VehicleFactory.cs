using FactoryMethod.Interface;

namespace FactoryMethod.Creator
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string vehicle);
    }
}