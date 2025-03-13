using FactoryMethod.Vehicle;

namespace FactoryMethod.Factories
{
    public class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
