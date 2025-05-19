using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public interface ITransportFactory
    {
        IAirCraft CreateTransportAircraft();
        ILandVehicle CreateTransportVehicle();
    }
}
