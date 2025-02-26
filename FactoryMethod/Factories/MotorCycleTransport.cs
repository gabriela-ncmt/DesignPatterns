using FactoryMethod.Vehicle;

namespace FactoryMethod.Factories
{
    public class MotorCycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
