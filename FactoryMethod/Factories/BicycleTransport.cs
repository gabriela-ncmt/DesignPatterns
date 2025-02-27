using FactoryMethod.Vehicle;

namespace FactoryMethod.Factories
{
    public class BicycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bicycle();
        }
    }
}
