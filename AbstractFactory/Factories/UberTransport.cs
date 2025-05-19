using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public class UberTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Car();
        }
    }
}
