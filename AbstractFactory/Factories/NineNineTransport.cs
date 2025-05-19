using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public class NineNineTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new MotorCycle();
        }
    }
}
