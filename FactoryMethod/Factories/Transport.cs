using FactoryMethod.Vehicle;

namespace FactoryMethod.Factories
{
    public abstract class Transport
    {
        public void StartTransport()
        {
            IVehicle vehicle = CreateTransport();
            vehicle.StartRoute();
        }

        protected abstract IVehicle CreateTransport();
    }
}
